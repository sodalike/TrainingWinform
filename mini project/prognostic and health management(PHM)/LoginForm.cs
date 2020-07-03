using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace prognostic_and_health_management_PHM_
{


    public partial class Form_Login : Form
    {
        string strConnString = "Data Source=192.168.0.81;Initial Catalog=PHMModelDB;User ID=sa;Password=p@ssw0rd!";
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Login_Ok_Click(object sender, EventArgs e)
        {
            LoginProcess();
        }

        private void LoginProcess()
        {
            
            if (string.IsNullOrEmpty(Txt_UserID.Text) || string.IsNullOrEmpty(Txt_Password.Text))
            {
                MessageBox.Show(this, "아이디/패스워드를 입력하세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            string strUserId = string.Empty;
            try // = static과 비슷, 무조건 실행
            {

                using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Select userID FROM userTbl" +
                                      " Where userID = @userID " +
                                      "  And Password = @password ";
                    SqlParameter parmuUserID = new SqlParameter("@userID", SqlDbType.VarChar, 12);
                    parmuUserID.Value = Txt_UserID.Text;
                    cmd.Parameters.Add(parmuUserID);
                    SqlParameter parmPassWord = new SqlParameter("@password", SqlDbType.VarChar, 20); //
                    parmPassWord.Value = Txt_Password.Text;
                    cmd.Parameters.Add(parmPassWord);

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    strUserId = reader["UserId"] != null ? reader["UserId"].ToString() : " ";
                    if (strUserId != "")
                    {
                        Commons.LOGINUSERID = strUserId;
                        MessageBox.Show(this, "접속성공", "로그인");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(this, "접속실패", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    Debug.WriteLine("On the Debug");
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(this, $"Error : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           

        }

        private void Login_Cancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void Txt_UserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // 엔터
            {
                Txt_Password.Focus();
            }
        }

        private void Txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) 
            {
                LoginProcess();
            }
        }
    }
}
