using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

//F12 - 정의로 이동
namespace BookRentalShop20
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 캔슬버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Environment.Exit(0);
        }
        /// <summary>
        /// 로그인 처리버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOK_Click(object sender, EventArgs e)
        {
            LoginProcess();
        }

        private void TxtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // 엔터
            {
                TxtPassWord.Focus();
            }
        }

        private void TxtPassWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // 엔터
            {
                LoginProcess();
            }
        }

        private void LoginProcess()
        {
            //throw new NotImplementedException();
            if //((TxtUserID.Text == null || TxtUserID.Text == "") ||
               //(TxtPassWord.Text == null || TxtPassWord.Text == ""))
               (string.IsNullOrEmpty(TxtUserID.Text)|| string.IsNullOrEmpty(TxtPassWord.Text))                
                {
                MetroMessageBox.Show(this, "아이디/패스워드를 입력하세요!", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string strUserId = string.Empty;
            try
            {

                using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Select userID FROM userTBL" +
                                      " Where userID = @userID " +
                                      "  And Password = @password ";
                    SqlParameter parmuUserID = new SqlParameter("@userID", SqlDbType.VarChar, 12);
                    parmuUserID.Value = TxtUserID.Text;
                    cmd.Parameters.Add(parmuUserID);
                    SqlParameter parmPassWord = new SqlParameter("@password", SqlDbType.VarChar, 20);
                    parmPassWord.Value = TxtPassWord.Text;
                    cmd.Parameters.Add(parmPassWord);

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    strUserId = reader["UserId"] != null ? reader["UserId"].ToString() : " ";
                    if (strUserId != "")
                    {
                        Commons.LOGINUSERID = strUserId;
                        MetroMessageBox.Show(this, "접속성공", "로그인");
                        this.Close();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "접속실패", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    Debug.WriteLine("On the Debug");
                }


                
            }
            catch (Exception ex)
            {

                MetroMessageBox.Show(this, $"Error : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                return;
            }

           


            
        }
    }
}
