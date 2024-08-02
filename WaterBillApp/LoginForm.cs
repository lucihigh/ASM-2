using System;
using System.Windows.Forms;

namespace WaterBillApp
{
    public partial class LoginForm : Form
    {
        public bool IsAuthenticated { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Simple authentication logic (replace with your own logic)
            if (username == "admin" && password == "admin")
            {
                IsAuthenticated = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
