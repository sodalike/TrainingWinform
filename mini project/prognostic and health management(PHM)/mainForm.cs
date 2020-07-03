using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prognostic_and_health_management_PHM_
{

    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Bt_Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Form_Login loginForm = new Form_Login();
            loginForm.ShowDialog();
            
        }
    }

    

}
