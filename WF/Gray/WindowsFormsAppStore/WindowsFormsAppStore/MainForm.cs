using System;
using System.Collections.Generic;
using System.IO;
using Visitor;
using System.Runtime.Serialization.Json;

namespace WindowsFormsAppStore
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        List<string> tags = null;
        UserModel LogginPassword = null;
        VisitorObj Visitor;
        public MainForm( )
        {
            InitializeComponent();
            advatisingUC1.SetTags(tags);
            try
            {
                using (FileStream fs = new FileStream("LogInInfo.json", FileMode.OpenOrCreate))
                {
                    DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(UserModel));
                    if (fs.Length != 0)
                    {
                        LogginPassword = (UserModel)jsonFormatter.ReadObject(fs);
                    }

                }
            }
            catch
            {
                File.Create("LogInInfo.json");
            }
            if (LogginPassword.Login != null && LogginPassword.Password != null)
            {
                
                Visitor = new VisitorObj(LogginPassword.Login, LogginPassword.Password);
                buttonSignIn.Text = "Sign out";
                buttonSignUp.Visible = false;
                tags = Visitor.GetTags();
                advatisingUC1.SetTags(tags);
                buttonHistory.Visible = true;
                buttonInfo.Visible = true;
                labelNeedToSignIN.Visible = false;
                labelNiceToDeeYou.Text = "Nice to see you\nMr." + Visitor.GetUserDataWithoutSecretInfo().Surname;
            }
            
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
                Visitor = null;
                LogginPassword = null;
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

            labelNiceToDeeYou.Visible = false;
            loginUC1.Visible = false;
             signUpUC1.Visible = true;
 
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            labelNiceToDeeYou.Visible = false;
            purchasehistoryUC1.Visible = true;
            pesonalInfoUC1.Visible = false;
            if (Visitor != null)
            {
                purchasehistoryUC1.SetPurchaseHistoryBll(Visitor.GetUserDataWithoutSecretInfo().Nickname);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            labelNiceToDeeYou.Visible = false;
            pesonalInfoUC1.Visible = true;
            purchasehistoryUC1.Visible = false;
            if (Visitor != null)
            {
                pesonalInfoUC1.SetInfo(Visitor.GetUserDataWithoutSecretInfo());
            }
        }

        private void loginUC1_VisibleChanged(object sender, EventArgs e)
        {
            if (loginUC1.GetVisitor != null && buttonSignIn.Text != "Sign out")
            {
                labelNiceToDeeYou.Visible = true;
                LogginPassword = loginUC1.LoginPassword;
                Visitor = loginUC1.GetVisitor;///
                buttonSignIn.Text = "Sign out";
                buttonSignUp.Visible = false;
                tags = Visitor.GetTags();
                advatisingUC1.SetTags(tags);
                buttonHistory.Visible = true;
                buttonInfo.Visible = true;
                labelNeedToSignIN.Visible = false;
                labelNiceToDeeYou.Text = "Nice to see you\nMr." + Visitor.GetUserDataWithoutSecretInfo().Surname;
            }
        }

        private void MainForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            if(LogginPassword!=null)
            {              
                using (FileStream fs = new FileStream("LogInInfo.json", FileMode.Create))
                {
                    DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(UserModel));
                    jsonFormatter.WriteObject(fs, LogginPassword);
                }
            }
            else
            {
                using (FileStream fs = new FileStream("LogInInfo.json", FileMode.Create))
                {
                    LogginPassword = new UserModel { Login = null, Password = null };
                    DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(UserModel));
                    jsonFormatter.WriteObject(fs, LogginPassword);
                }
            }
        }
    }
}
