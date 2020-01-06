using System;
using System.Drawing;
using System.Windows.Forms;
using Bll.Abstract;
using Bll.Concrete;
using Dto;

namespace WindowsFormsAppStore
{
    public partial class RestorePasswordUC : MetroFramework.Controls.MetroUserControl
    {
        readonly IUserBll UserBll = new UserBll();
        public RestorePasswordUC()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            SetDefoult();
            this.Visible = false;
        }

        private void buttonAskLogin_Click(object sender, EventArgs e)
        {
            if (UserBll.GetSpesialQuestion(textBoxLogin.Text) != "")
            {
                textBoxQestion.Text = UserBll.GetSpesialQuestion(textBoxLogin.Text);
                textBoxAnswer.ReadOnly = false;
                textBoxLogin.ReadOnly = true;
                buttonAnswer.Visible = true;
                buttonAskLogin.Visible = false;
            }
            else
            {
                labelAskLogin.ForeColor = Color.DarkRed;
            }
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            if(UserBll.CompareAnswer(textBoxAnswer.Text, textBoxLogin.Text))
            {
                textBoxAnswer.ReadOnly = true;
                textBoxPassword.ReadOnly = false;
                textBoxRepeatPassword.ReadOnly = false;
                buttonChange.Visible = true;
                buttonAnswer.Visible = false;
            }
            else
            {
                labelAnswer.ForeColor= Color.DarkRed;
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if(textBoxPassword.Text==textBoxRepeatPassword.Text && textBoxPassword.Text.Length>=6)
            {
                UserBll.ChangePassword(textBoxLogin.Text, textBoxAnswer.Text, textBoxPassword.Text);
                SetDefoult();
                this.Visible = false;
            }
            else
            {
                labelNewPassword.ForeColor = Color.DarkRed;
            }
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            labelAskLogin.ForeColor = Color.Green;
        }

        private void textBoxanswer_TextChanged(object sender, EventArgs e)
        {
            labelAnswer.ForeColor = Color.Green;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            labelNewPassword.ForeColor= Color.Green;
        }
    
        private void textBoxRepeatPassword_TextChanged(object sender, EventArgs e)
        {
             labelNewPassword.ForeColor = Color.Green;
        }

        private void SetDefoult()
        {
            labelAskLogin.ForeColor = Color.Green;
            labelNewPassword.ForeColor = Color.Green;
            labelNewPassword.ForeColor = Color.Green;
            labelAnswer.ForeColor = Color.Green;
            textBoxQestion.Text = "The question is up to you.";
            textBoxRepeatPassword.Text = "";
            textBoxPassword.Text = "";
            textBoxLogin.Text = "";
            textBoxAnswer.Text = "";
            textBoxQestion.ReadOnly = true;
            textBoxRepeatPassword.ReadOnly = true;
            textBoxPassword.ReadOnly = true;
            textBoxLogin.ReadOnly = false;
            textBoxAnswer.ReadOnly = true;
            buttonAnswer.Visible = false;
            buttonChange.Visible = false;
            buttonAskLogin.Visible = true;
        }
    }
}
