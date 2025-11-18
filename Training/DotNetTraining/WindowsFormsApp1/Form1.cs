using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class LoginEventArgs : EventArgs
    {
        public string Username { get; set; }
        public LoginEventArgs(string username)
        {
            Username = username;
        }
    }
    public partial class LoginForm : Form
    {
        public delegate void LoginSuccessEventHandler(object sender, LoginEventArgs e);
        public event LoginSuccessEventHandler LoginSuccess;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            if (username == "admin" && password == "password")
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoginSuccess?.Invoke(this, new LoginEventArgs(username));

                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
