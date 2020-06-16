using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockApp
{
    public partial class Clock : Form
    {
        public Clock()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
       {
       
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label1.Text = now.ToString("HH:mm:ss");
        }

        private void Clock_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form 로드 시 발생");
        }

        private void Clock_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Form 클로즈 시 발생");

        }

        private void Clock_Activated(object sender, EventArgs e)
        {
            MessageBox.Show("Form 활성화 시 발생");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Clock_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("진짜 닫을래?", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                e.Cancel = false; // 취소를 안시켜서 종료
            }
            else
            {
                e.Cancel = true; //최소시키니깐 종료 안됨
            }    
        }
    }
}
