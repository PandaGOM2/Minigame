using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minigame
{
    public partial class Login : Form
    {
        private RegistrationForm registrationForm;
       
        public Login( RegistrationForm registrationForm )
        {
            InitializeComponent();
            this.registrationForm = registrationForm;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (registrationForm.UserExists(username) && CheckPassword(username, password))
            {
                MessageBox.Show("로그인 성공!", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                GameSelect main = new GameSelect();
                main.Show();
            }
            else
            {
                MessageBox.Show("아이디 또는 비밀번호가 올바르지 않습니다.", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CheckPassword(string username, string password)
        {
            foreach (var user in registrationForm.Users)
            {
                if (user.Length > 1 && user[1] == username && user.Length > 2 && user[2] == password)
                {
                    return true;
                }
            }
            return false;
        }

        private void backLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registrationForm.Show();
            this.Close();
        }
    }
}
