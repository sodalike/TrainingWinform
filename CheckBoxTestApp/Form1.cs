using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxTestApp
{
    public partial class Form1 : Form
    {
        // private string strTemp = "";

        //private void UpdateLabel(string s, bool b)
        //{
        //    if(b == true)
        //    {
        //        strTemp +=  s + " ";
        //        label1.Text = strTemp;
        //    }
        //    else // 이거 해석 불가
        //    {
        //        strTemp = label1.Text;
        //        int i = strTemp.IndexOf(s.Substring(0, 1));
        //        int j = i + s.Length;
        //        label1.Text = strTemp.Remove(i, j - 1);
        //    }
        //}
        //전체 주석 ctrl + k + c

        private void UpdateLable()
        {
            string strchk1 = " ", strchk2 = " ", strchk3 = " ", strchk4 = " ";
            if (checkBox1.Checked) strchk1 = checkBox1.Text;
            else strchk1 = "";
            if (checkBox2.Checked) strchk2 = checkBox2.Text;
            else strchk2 = "";
            if (checkBox3.Checked) strchk3 = checkBox3.Text;
            else strchk3 = "";
            if (checkBox4.Checked) strchk4 = checkBox4.Text;
            else strchk4 = "";

            label1.Text = "좋아하는 과일 : " + strchk1 + " " + strchk2 + " " + strchk3 + " " + strchk4 + " ";
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) // 사과
        {
            UpdateLable();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) // 딸기
        {
            UpdateLable();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e) // 오렌지
        {
            UpdateLable();

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e) // 바나나
        {
           UpdateLable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "좋아하는 과일 : ";
        }
    }
}
