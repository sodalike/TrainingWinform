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
    public partial class BooksForm : MetroForm
    {
        string mode = "";

        public BooksForm()
        {
            InitializeComponent();
        }

           
        private void UpdateData()
        {
            using(SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open(); //DB열기
                string strQuery = "SELECT b.Idx, b.Author, " +
                                  "       b.Division, " +
                                  "       d.Names AS 'DivNames', " + 
	                              "       b.Names, " +
	                              "       b.ReleaseDate, " + 
	                              "       b.ISBN, " + 
	                              "REPLACE (CONVERT(VARCHAR, CAST(b.price AS MONEY), 1), '.00', '') AS price " +
                                  "   FROM dbo.bookstbl AS b " +
                                  "  INNER JOIN dbo.divtbl AS d " +
                                  "     ON b.Division = d.Division";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn); // command 값이 포함되어잇다.
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "bookstbl");

                GrdBooksTBL.DataSource = ds;
                GrdBooksTBL.DataMember = "bookstbl";
            }

            DataGridViewColumn column = GrdBooksTBL.Columns[2]; //id컬럼
            column.Visible = false;
        }

        private void GrdDivTbl_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = GrdBooksTBL.Rows[e.RowIndex];
                TxtIdx.Text = data.Cells[0].Value.ToString();
                TxtIdx.ReadOnly = true;
                TxtIdx.BackColor = Color.SkyBlue;
                TxtAuthor.Text = data.Cells[1].Value.ToString();
                //CboDivision.SelectedIndex = CboDivision.FindString(data.Cells[3].Value.ToString()); // Select code 1
                CboDivision.SelectedValue = data.Cells[2].Value.ToString(); // Select code 2
                TxtNames.Text = data.Cells[4].Value.ToString();

                DtpReleaseDate.CustomFormat = "yyyy-MM-dd";
                DtpReleaseDate.Value = DateTime.Parse(data.Cells[5].Value.ToString());

                TxtISBN.Text = data.Cells[6].Value.ToString();
                TxtPrice.Text = data.Cells[7].Value.ToString();


                mode = "UPDATE";


            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            //TxtIdx.Text = TxtAuthor.Text = "";
            //TxtIdx.ReadOnly = false;
            //TxtIdx.BackColor = Color.White;
            ClearTextControls();
            mode = "INSERT";//신규는 INSERT
        }
        
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNames.Text)||string.IsNullOrEmpty(TxtAuthor.Text))
                //if (string.IsNullOrEmpty(TxtMobile.Text) || string.IsNullOrEmpty(TxtISBN.Text))

                {
                    MetroMessageBox.Show(this, "빈값은 저장할 수 없습니다.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }
            SaveProcess();
            UpdateData();
            ClearTextControls();
            //DeleteProcss();

                           
        }

        private void DeleteProcss()
        {
            using(SqlConnection conn = new SqlConnection(Commons.CONNSTRING)) 
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM dbo.divtbl WHERE Division = @Division";
                SqlParameter parmDivision = new SqlParameter("@Division", SqlDbType.Char, 4);
                parmDivision.Value = TxtIdx.Text;
                cmd.Parameters.Add(parmDivision);

                cmd.ExecuteNonQuery();
            }
        }

        private void ClearTextControls()
        {
            TxtISBN.Text=TxtNames.Text = TxtPrice.Text = TxtIdx.Text = TxtAuthor.Text = "";
            
            CboDivision.SelectedIndex = -1;
            TxtIdx.ReadOnly = true;
            TxtIdx.BackColor = Color.Beige;
            TxtNames.Focus();
            DtpReleaseDate.CustomFormat = " ";
            DtpReleaseDate.Format = DateTimePickerFormat.Custom;
        }

        private void SaveProcess() // 실시간 업로딩
        {
            //db저장 프로제스
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                string strQuery = "";
                if (mode == "UPDATE")
                {
                    strQuery = " UPDATE dbo.bookstbl " +
                               " SET Author = @Author " +
                               "   , Division = @Division " +
                               "   , Names = @Names " +
                               "   , ReleaseDate = @ReleaseDate " +
                               "   , ISBN = @ISBN " +
                               "   , Price = @Price " +
                               "  WHERE Idx = @Idx ";
                }
                else if (mode == "INSERT")
                {
                    strQuery = "INSERT INTO dbo.bookstbl(Author, Division, Names, ReleaseDate, ISBN, Price) " +
                               "     VALUES (@Author, @Division, @Names, @ReleaseDate, @ISBN, @Price)";
                }
                cmd.CommandText = strQuery;
                SqlParameter parmAuthor = new SqlParameter("@Author", SqlDbType.NVarChar, 45);
                parmAuthor.Value = TxtAuthor.Text;
                cmd.Parameters.Add(parmAuthor);

                SqlParameter parmDivision = new SqlParameter("@Division", SqlDbType.Char, 4);
                parmDivision.Value = CboDivision.SelectedValue;
                cmd.Parameters.Add(parmDivision);

                SqlParameter parmNames = new SqlParameter("@Names", SqlDbType.VarChar, 100);
                parmNames.Value = TxtNames.Text;
                cmd.Parameters.Add(parmNames);

                SqlParameter parmReleaseDate = new SqlParameter("@ReleaseDate", SqlDbType.Date);
                parmReleaseDate.Value =DtpReleaseDate.Value;
                cmd.Parameters.Add(parmReleaseDate);

                SqlParameter parmISBN = new SqlParameter("@ISBN", SqlDbType.VarChar, 200);
                parmISBN.Value = TxtISBN.Text;
                cmd.Parameters.Add(parmISBN);

                SqlParameter parmPrice = new SqlParameter("@Price", SqlDbType.Decimal, 10);
                parmPrice.Value = TxtPrice.Text;
                cmd.Parameters.Add(parmPrice);

                
                if (mode=="UPDATE")
                {
                    SqlParameter parmIdx = new SqlParameter("@Idx", SqlDbType.Int);
                    parmIdx.Value = TxtIdx.Text;
                    cmd.Parameters.Add(parmIdx);
                }
               

                cmd.ExecuteNonQuery();
            }
        }

        private void TxtNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar ==13)
            {
                BtnSave_Click(sender, new EventArgs());
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtIdx.Text) || string.IsNullOrEmpty(TxtAuthor.Text))
            {
                MetroMessageBox.Show(this, "빈값은 삭제할 수 없습니다.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DeleteProcss();
            UpdateData();
            ClearTextControls();

        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            DtpReleaseDate.CustomFormat = "yyyy-MM-dd";
            DtpReleaseDate.Format = DateTimePickerFormat.Custom;

            UpdateData();

            UpdateCboDivision();
        }

        private void UpdateCboDivision()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT Division, Names FROM divtbl";
                SqlDataReader reader = cmd.ExecuteReader();
                Dictionary<string, string> temps = new Dictionary<string, string>();
                while (reader.Read()) 
                {
                    temps.Add (reader[0].ToString(), reader[1].ToString());
                }
                CboDivision.DataSource = new BindingSource(temps, null);
                CboDivision.DisplayMember = "Value";
                CboDivision.ValueMember = "Key";
                CboDivision.SelectedIndex = -1;
            }
        }

        private void DtpReleaseDate_ValueChanged(object sender, EventArgs e)
        {
            DtpReleaseDate.CustomFormat = "yyyy-MM-dd";
            DtpReleaseDate.Format = DateTimePickerFormat.Custom;
        }
    }
}
