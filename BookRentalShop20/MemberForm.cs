﻿using MetroFramework;
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
    public partial class MemberForm : MetroForm
    {
        string mode = "";

        public MemberForm()
        {
            InitializeComponent();
        }

           
        private void UpdateData()
        {
            using(SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open(); //DB열기
                string strQuery = "SELECT Idx, Names, Levels, Addr, Mobile, Email " + 
                                  "  FROM membertbl";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "membertbl");

                GrdMemberTBL.DataSource = ds;
                GrdMemberTBL.DataMember = "membertbl";
            }
        }

        private void GrdDivTbl_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow data = GrdMemberTBL.Rows[e.RowIndex];
                TxtIdx.Text = data.Cells[0].Value.ToString();
                TxtNames.Text = data.Cells[1].Value.ToString();
                TxtIdx.ReadOnly = true;
                TxtIdx.BackColor = Color.SkyBlue;
                CboLevels.SelectedIndex = CboLevels.FindString(data.Cells[2].Value.ToString());
                TxtAddr.Text = data.Cells[3].Value.ToString();
                TxtMobile.Text = data.Cells[4].Value.ToString();
                TxtEmail.Text = data.Cells[5].Value.ToString();

                mode = "UPDATE";


            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            TxtIdx.Text = TxtNames.Text = "";
            TxtIdx.ReadOnly = false;
            TxtIdx.BackColor = Color.White;

            mode = "INSERT";//신규는 INSERT
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtAddr.Text)||string.IsNullOrEmpty(TxtNames.Text))
                if (string.IsNullOrEmpty(TxtMobile.Text) || string.IsNullOrEmpty(TxtEmail.Text))

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
            TxtEmail.Text=TxtAddr.Text = TxtMobile.Text = TxtIdx.Text = TxtNames.Text = "";
            CboLevels.SelectedIndex = -1;
            TxtIdx.ReadOnly = true;
            TxtIdx.BackColor = Color.Beige;
            TxtAddr.Focus();
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
                    strQuery = " UPDATE dbo.membertbl " +
                               "   SET Names = @Names " +
                               "     , Levels = @Levels " +
                               "     , Addr = @Addr " +
                               "     , Mobile = @Mobile " +
                               "     , Email = @Email " +
                               " WHERE Idx = @Idx";
                }
                else if (mode == "INSERT")
                {
                    strQuery = "INSERT INTO dbo.membertbl (Names, Levels, Addr, Mobile, Email)" + 
                               "                   VALUES (@Names, @Levels, @Addr, @Mobile, @Email)";
                }
                cmd.CommandText = strQuery;
                SqlParameter parmNames = new SqlParameter("@Names", SqlDbType.NVarChar, 45);
                parmNames.Value = TxtNames.Text;
                cmd.Parameters.Add(parmNames);

                SqlParameter parmLevels = new SqlParameter("@Levels", SqlDbType.Char, 1);
                parmLevels.Value = CboLevels.SelectedItem;
                cmd.Parameters.Add(parmLevels);

                SqlParameter parmAddr = new SqlParameter("@Addr", SqlDbType.VarChar, 100);
                parmAddr.Value = TxtAddr.Text;
                cmd.Parameters.Add(parmAddr);

                SqlParameter parmMobile = new SqlParameter("@Mobile", SqlDbType.VarChar, 13);
                parmMobile.Value = TxtMobile.Text;
                cmd.Parameters.Add(parmMobile);

                SqlParameter parmEmail = new SqlParameter("@Email", SqlDbType.VarChar, 50);
                parmEmail.Value = TxtEmail.Text;
                cmd.Parameters.Add(parmEmail);

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
            if (string.IsNullOrEmpty(TxtIdx.Text) || string.IsNullOrEmpty(TxtNames.Text))
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
            UpdateData();
        }
    }
}
