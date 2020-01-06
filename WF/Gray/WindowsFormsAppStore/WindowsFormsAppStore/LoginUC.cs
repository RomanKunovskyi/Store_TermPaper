using System;
using System.Drawing;
using Bll.Abstract;
using Bll.Concrete;
using Dto;
using Visitor;

namespace WindowsFormsAppStore
{
    public partial class LoginUC : MetroFramework.Controls.MetroUserControl
    {
        IUserBll UserBll = new UserBll();
        public VisitorObj GetVisitor { get; private set; } = null;
        public UserModel LoginPassword { get; private set; }

        public LoginUC()
        {
            InitializeComponent();
        }

        private void buttonRestorePassword_Click(object sender, EventArgs e)
        {
            SetDefoult();
            restorePasswordUC1.Visible = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            SetDefoult();
            this.Visible = false;
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            labelLogin.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            labelPassword.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            UserDto User = null;
            if(UserBll.LoginIsFree(textBoxLogin.Text)!=true)
            {              
                User = UserBll.SignIn(textBoxLogin.Text, textBoxPassword.Text);         
            }
            else
            {
                labelLogin.ForeColor = Color.DarkRed;
            }
            if(User!=null)
            {
                LoginPassword = new UserModel() { Login = textBoxLogin.Text, Password = textBoxPassword.Text};
                GetVisitor = new VisitorObj(textBoxLogin.Text, textBoxPassword.Text);
                SetDefoult();
                this.Visible = false;
            }
            else
            {
                labelPassword.ForeColor = Color.DarkRed;
            }
        }
        private void SetDefoult()
        {
            textBoxLogin.Text = ""; 
            textBoxPassword.Text = "";
            labelPassword.ForeColor = Color.FromArgb(64, 64, 64); ;
            labelLogin.ForeColor = Color.FromArgb(64, 64, 64); ;
        }
        public void SignOut()
        {
           LoginPassword = null;
           GetVisitor = null;
        }
    }
}
