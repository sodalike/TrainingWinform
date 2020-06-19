using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentalShop20
{
    public partial class UserForm : MetroForm
    {
        string strConnString = "Data Source=192.168.0.81;Initial Catalog=bookrentalshopDB;Persist Security Info=True;User ID=sa;Password=p@ssw0rd!";
        string mode = "";

        public UserForm()
        {
            InitializeComponent();
        }

        private void DivForm_Load(object sender, EventArgs e)
        {
            UpdateData();//데이터 그리드DB 데이터 로딩하기
         
        }

       
        private void UpdateData()
        {
            using(SqlConnection conn = new SqlConnection(strConnString))
            {
                conn.Open(); //DB열기
                string strQuery = "SELECT id, userID, password, lastLoginDt, loginIpAddr " +
                                  "  FROM dbo.userTbl";
               // SqlCommand cmd = new SqlCommand(strQuery, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "userTbl");

                GrdUserTbl.DataSource = ds;
                GrdUserTbl.DataMember = "userTbl";
            }
            DataGridViewColumn column = GrdUserTbl.Columns[0];//ID columns
            column.Width = 40;
            column.HeaderText = "순번";
            column = GrdUserTbl.Columns[1];//userID 컬럼
            column.Width = 80;
            column.HeaderText = "아이디";
            column = GrdUserTbl.Columns[2];
            column.Width = 100;
            column.HeaderText = "패스워드";
            column = GrdUserTbl.Columns[3];
            column.Width = 120;
            column.HeaderText = "최종접속시간";
            column = GrdUserTbl.Columns[4];
            column.Width = 140;
            column.HeaderText = "최종접속아이피";
        }

        /// <summary>
        /// 그리드 셀 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void GrdDivTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>-1)
            {
                DataGridViewRow data = GrdUserTbl.Rows[e.RowIndex];
                TxtId.Text = data.Cells[0].Value.ToString();
                TxtUserID.Text = data.Cells[1].Value.ToString();
                TxtPassword.Text = data.Cells[2].Value.ToString();
                
                mode = "UPDATE";//데이터수정
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            TxtUserID.Text = TxtPassword.Text = "";
            TxtUserID.ReadOnly = false;
            TxtUserID.BackColor = Color.White;

            mode = "INSERT";//신규는 INSERT
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUserID.Text)||string.IsNullOrEmpty(TxtPassword.Text))
            {
                MetroMessageBox.Show(this, "빈값은 저장할 수 없습니다.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }
            SaveProcess();
            UpdateData();
            ClearTextControls();
            DeleteProcss();

                           
        }

        private void DeleteProcss()
        {
            using(SqlConnection conn = new SqlConnection(strConnString)) 
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM dbo.divtbl WHERE Division = @Division";
                SqlParameter parmDivision = new SqlParameter("@Division", SqlDbType.Char, 4);
                parmDivision.Value = TxtUserID.Text;
                cmd.Parameters.Add(parmDivision);

                cmd.ExecuteNonQuery();
            }
        }

        private void ClearTextControls()
        {
            TxtId.Text = TxtUserID.Text = TxtPassword.Text = "";
            //TxtUserID.ReadOnly = false;
            //TxtUserID.BackColor = Color.White;
            TxtUserID.Focus();
        }

        private void SaveProcess() // 실시간 업로딩
        {
            //db저장 프로제스
            using (SqlConnection conn = new SqlConnection(strConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                string strQuery = "";
                if (mode == "UPDATE")
                {
                    strQuery = "UPDATE dbo.userTbl " + 
                               "   SET userID = @UserID " +
                               "     , password = @Password" +
                               " WHERE Id = @Id";
                    
                }
                else if (mode == "INSERT")
                {
                    strQuery = "INSERT INTO dbo.userTbl ( userID, password )" + 
                               " VALUES (@UserID, @Password) ";
                }
                cmd.CommandText = strQuery;
                SqlParameter parmUserID= new SqlParameter("@UserID", SqlDbType.VarChar, 12);
                parmUserID.Value = TxtUserID.Text;
                cmd.Parameters.Add(parmUserID);

                SqlParameter parmPassword = new SqlParameter("@Password", SqlDbType.VarChar, 20);
                parmPassword.Value = TxtPassword.Text;
                cmd.Parameters.Add(parmPassword);

                if (mode == "UPDATE")
                {
                    SqlParameter parmId = new SqlParameter("@Id", SqlDbType.Int);
                    parmId.Value = TxtId.Text;
                    cmd.Parameters.Add(parmId);
                }

                cmd.ExecuteNonQuery();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        { /*
            if (string.IsNullOrEmpty(TxtUserID.Text) || string.IsNullOrEmpty(TxtPassword.Text))
            {
              
                MetroMessageBox.Show(this, "빈값은 삭제할 수 없습니다.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
               
             }

            DeleteProcss();
            UpdateData();
            ClearTextControls();
            */

        }
    }
}
