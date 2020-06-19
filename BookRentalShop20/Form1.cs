using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace BookRentalShop20
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (MetroMessageBox.Show(this, "정말 종료하시겠습니까?", "종료", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                foreach(var item in this.MdiChildren)
                {
                    item.Close();
                }
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void InitChildForm(Form form, string strFormTitle)
        {
            
            form.Text = strFormTitle;
            form.Dock = DockStyle.Fill;
            form.MdiParent = this; //여기까지 초기화
            form.Show();
            form.WindowState = FormWindowState.Maximized; // 실행
        }

        private void MnuItemDivMng_Click(object sender, System.EventArgs e)
        {
            DivForm form = new DivForm(); // 자식 폼
            InitChildForm(form, "구분코드 관리");       
        }

        private void 사용자관리UToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            UserForm form = new UserForm(); // 자식 폼
            InitChildForm(form, "사용자 관리");
        }
    }
}
