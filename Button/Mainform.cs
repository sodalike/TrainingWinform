using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // flat
        {
            LblButtonStyle.Text = FlatStyle.Flat.ToString();
        }

        private void BtnPopup_Click(object sender, EventArgs e)
        {
            LblButtonStyle.Text = FlatStyle.Popup.ToString();
        }

        private void BtnStandard_Click(object sender, EventArgs e)
        {
            LblButtonStyle.Text = FlatStyle.Standard.ToString();
        }

        private void BtnSystem_Click(object sender, EventArgs e)
        {
            LblButtonStyle.Text = FlatStyle.System.ToString();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            LblButtonStyle.Text = "결과표시";
        }
    }
}
