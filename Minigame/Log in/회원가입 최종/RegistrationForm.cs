using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 회원가입_최종
{
    public partial class RegistrationForm : Form
    {
        private List<string[]> users = new List<string[]>();

        public RegistrationForm()
        {
            InitializeComponent();
        }

        public List<string[]> Users
        {
            get { return users; }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("모든 필드를 채워주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UserExists(username))
            {
                MessageBox.Show("이미 등록된 아이디입니다. 다른 아이디를 선택해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            users.Add(new string[] { name, username, password });

         

            MessageBox.Show("회원가입이 완료되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

            nameTextBox.Text = "";
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        internal bool UserExists(string username)
        {
            foreach (var user in users)
            {
                if (user.Length > 1 && user[1] == username)
                {
                    return true;
                }
            }
            return false;
        }

     

        private void loginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm(this);
            loginForm.Show();
            this.Hide();
        }
    }
}