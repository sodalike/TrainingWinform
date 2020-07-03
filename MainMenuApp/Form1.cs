using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenuApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 파일FToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 새파일NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text += 새파일NToolStripMenuItem.Text + Environment.NewLine;
            toolStripStatusLabel1.Text = 새파일NToolStripMenuItem.Text;
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text += 저장SToolStripMenuItem.Text + Environment.NewLine;
            MessageBox.Show("저장했습니다.");

        }

        private void 프로그램정보AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }

        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(e.Location);
            }
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            LblMouseLocation.Text = $"(X,Y) = ({e.X}, {e.Y})";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            새파일NToolStripMenuItem_Click(sender, e);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            toolStripComboBox1.Items.Add("Python");
            toolStripComboBox1.Items.Add("C");
            toolStripComboBox1.Items.Add("C++");
            toolStripComboBox1.Items.Add("Java");
            toolStripComboBox1.Items.Add("C#");
        }
    }
}
