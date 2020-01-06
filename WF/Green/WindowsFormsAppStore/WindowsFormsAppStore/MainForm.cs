using Bll.Concrete;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsAppStore
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        List<string> tags = null;
        public MainForm()
        {
            InitializeComponent();
            advatisingUC1.SetTags(tags);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (buttonSignIn.Text != "Sign out")
            {
                signUpUC1.Visible = false;
                loginUC1.Visible = true;
            }
            else
            {
                loginUC1.SignOut();
                tags = null;
                advatisingUC1.SetTags(tags);
                buttonSignIn.Text = "Sign in";
                buttonSignUp.Visible = true;
                buttonHistory.Visible = false;
                buttonInfo.Visible = false;
                labelNeedToSignIN.Visible = true ;
                pesonalInfoUC1.Visible = false ;
                purchasehistoryUC1.Visible = false;
                labelNiceToDeeYou.Text = "";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                loginUC1.Visible = false;
                signUpUC1.Visible = true;
 
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            purchasehistoryUC1.Visible = true;
            pesonalInfoUC1.Visible = false;
            if (loginUC1.Visitor != null)
            {
                purchasehistoryUC1.SetPurchaseHistoryBll(loginUC1.Visitor.GetUserDataWithoutSecretInfo().Nickname);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            pesonalInfoUC1.Visible = true;
            purchasehistoryUC1.Visible = false;
            if (loginUC1.Visitor != null)
            {
                pesonalInfoUC1.SetInfo(loginUC1.Visitor.GetUserDataWithoutSecretInfo());
            }
        }

        private void loginUC1_VisibleChanged(object sender, EventArgs e)
        {
            if (loginUC1.Visitor != null && buttonSignIn.Text != "Sign out")
            {
                buttonSignIn.Text = "Sign out";
                buttonSignUp.Visible = false;
                tags = loginUC1.Visitor.GetTags();
                advatisingUC1.SetTags(tags);
                buttonHistory.Visible = true;
                buttonInfo.Visible = true;
                labelNeedToSignIN.Visible = false;
                labelNiceToDeeYou.Text = "Nice to see you\nMr." + loginUC1.Visitor.GetUserDataWithoutSecretInfo().Surname;
            }
        }
    }
}
