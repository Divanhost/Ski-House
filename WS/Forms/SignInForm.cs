using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WS.Forms;
using WS.DAO;

namespace WS
{
    public partial class SignInForm : BaseForm
    {
        public SignInForm()
        {
            InitializeComponent();
            loginTextBox.Text = "user";
            passwordTextBox.Text = "1234";
        }

        
        private void signInButton_Click(object sender, EventArgs e)
        {

            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            var user = UserDao.GetUsers().FirstOrDefault(u=> u.login.Equals(login) &&
                u.password.Equals(password));
            if (user != null)
            {
                LoginController.GetInstance().user = user;
                var menu =  new MainMenuForm();

                showNextForm(menu);
            }
            else
            {
                messageLabel.Text = "Access denied";
            }
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            messageLabel.Text = loginTextBox.Text;
        }
    }
}
