using System;
using System.Drawing;
using System.Windows.Forms;
using Bll.Abstract;
using Bll.Concrete;
using Dto;
using Visitor;

namespace WindowsFormsAppStore
{
    public partial class LoginUC : MetroFramework.Controls.MetroUserControl
    {
        IUserBll UserBll = new UserBll();
        public VisitorObj Visitor = null;
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
            labelLogin.ForeColor = Color.Green;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            labelPassword.ForeColor = Color.Green;
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
                Visitor = new VisitorObj(textBoxLogin.Text, textBoxPassword.Text);
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
            labelPassword.ForeColor = Color.Green;
            labelLogin.ForeColor = Color.Green;
        }
        public void SignOut()
        {
           Visitor = null;
        }
    }
}
