using System.Collections.Generic;

namespace WindowsFormsAppStore
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.Massage = new System.Windows.Forms.Label();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.labelNeedToSignIN = new System.Windows.Forms.Label();
            this.labelNiceToDeeYou = new System.Windows.Forms.Label();
            this.pesonalInfoUC1 = new WindowsFormsAppStore.PesonalInfoUC();
            this.advatesingMoreInformation3 = new WindowsFormsAppStore.AdvatesingMoreInformation();
            this.advatesingMoreInformation2 = new WindowsFormsAppStore.AdvatesingMoreInformation();
            this.advatesingMoreInformation1 = new WindowsFormsAppStore.AdvatesingMoreInformation();
            this.advatisingUC1 = new WindowsFormsAppStore.AdvatisingUC();
            this.purchasehistoryUC1 = new WindowsFormsAppStore.PurchasehistoryUC();
            this.signUpUC1 = new WindowsFormsAppStore.SignUpUC();
            this.loginUC1 = new WindowsFormsAppStore.LoginUC();
            this.SuspendLayout();
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.Color.Green;
            this.buttonSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignIn.ForeColor = System.Drawing.Color.White;
            this.buttonSignIn.Location = new System.Drawing.Point(489, 53);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(150, 31);
            this.buttonSignIn.TabIndex = 1;
            this.buttonSignIn.Text = "Sign in";
            this.buttonSignIn.UseVisualStyleBackColor = false;
            this.buttonSignIn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.Color.Green;
            this.buttonSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignUp.ForeColor = System.Drawing.Color.White;
            this.buttonSignUp.Location = new System.Drawing.Point(645, 53);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(150, 31);
            this.buttonSignUp.TabIndex = 4;
            this.buttonSignUp.Text = "Sign up";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.button2_Click);
            // 
            // Massage
            // 
            this.Massage.AutoSize = true;
            this.Massage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Massage.ForeColor = System.Drawing.Color.ForestGreen;
            this.Massage.Location = new System.Drawing.Point(642, 60);
            this.Massage.Name = "Massage";
            this.Massage.Size = new System.Drawing.Size(150, 17);
            this.Massage.TabIndex = 6;
            this.Massage.Text = "Sign out to sign up.";
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.Green;
            this.buttonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo.ForeColor = System.Drawing.Color.White;
            this.buttonInfo.Location = new System.Drawing.Point(23, 53);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(150, 31);
            this.buttonInfo.TabIndex = 11;
            this.buttonInfo.Text = "Your information";
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Visible = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.BackColor = System.Drawing.Color.Green;
            this.buttonHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHistory.ForeColor = System.Drawing.Color.White;
            this.buttonHistory.Location = new System.Drawing.Point(179, 53);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(150, 31);
            this.buttonHistory.TabIndex = 12;
            this.buttonHistory.Text = "Your history";
            this.buttonHistory.UseVisualStyleBackColor = false;
            this.buttonHistory.Visible = false;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // labelNeedToSignIN
            // 
            this.labelNeedToSignIN.AutoSize = true;
            this.labelNeedToSignIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNeedToSignIN.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelNeedToSignIN.Location = new System.Drawing.Point(23, 60);
            this.labelNeedToSignIN.Name = "labelNeedToSignIN";
            this.labelNeedToSignIN.Size = new System.Drawing.Size(191, 17);
            this.labelNeedToSignIN.TabIndex = 13;
            this.labelNeedToSignIN.Text = "Sign in to get information";
            // 
            // labelNiceToDeeYou
            // 
            this.labelNiceToDeeYou.AutoSize = true;
            this.labelNiceToDeeYou.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNiceToDeeYou.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelNiceToDeeYou.Location = new System.Drawing.Point(350, 53);
            this.labelNiceToDeeYou.Name = "labelNiceToDeeYou";
            this.labelNiceToDeeYou.Size = new System.Drawing.Size(0, 16);
            this.labelNiceToDeeYou.TabIndex = 16;
            // 
            // pesonalInfoUC1
            // 
            this.pesonalInfoUC1.Location = new System.Drawing.Point(33, 90);
            this.pesonalInfoUC1.Name = "pesonalInfoUC1";
            this.pesonalInfoUC1.Size = new System.Drawing.Size(258, 389);
            this.pesonalInfoUC1.TabIndex = 23;
            this.pesonalInfoUC1.Visible = false;
            // 
            // advatesingMoreInformation3
            // 
            this.advatesingMoreInformation3.BackColor = System.Drawing.Color.White;
            this.advatesingMoreInformation3.Location = new System.Drawing.Point(535, 112);
            this.advatesingMoreInformation3.Name = "advatesingMoreInformation3";
            this.advatesingMoreInformation3.Size = new System.Drawing.Size(240, 362);
            this.advatesingMoreInformation3.TabIndex = 20;
            this.advatesingMoreInformation3.Visible = false;
            // 
            // advatesingMoreInformation2
            // 
            this.advatesingMoreInformation2.BackColor = System.Drawing.Color.White;
            this.advatesingMoreInformation2.Location = new System.Drawing.Point(289, 112);
            this.advatesingMoreInformation2.Name = "advatesingMoreInformation2";
            this.advatesingMoreInformation2.Size = new System.Drawing.Size(240, 362);
            this.advatesingMoreInformation2.TabIndex = 19;
            this.advatesingMoreInformation2.Visible = false;
            // 
            // advatesingMoreInformation1
            // 
            this.advatesingMoreInformation1.BackColor = System.Drawing.Color.White;
            this.advatesingMoreInformation1.Location = new System.Drawing.Point(43, 112);
            this.advatesingMoreInformation1.Name = "advatesingMoreInformation1";
            this.advatesingMoreInformation1.Size = new System.Drawing.Size(240, 362);
            this.advatesingMoreInformation1.TabIndex = 18;
            this.advatesingMoreInformation1.Visible = false;
            // 
            // advatisingUC1
            // 
            this.advatisingUC1.BackColor = System.Drawing.Color.White;
            this.advatisingUC1.Location = new System.Drawing.Point(23, 90);
            this.advatisingUC1.Name = "advatisingUC1";
            this.advatisingUC1.Size = new System.Drawing.Size(776, 389);
            this.advatisingUC1.TabIndex = 17;
            // 
            // purchasehistoryUC1
            // 
            this.purchasehistoryUC1.BackColor = System.Drawing.Color.White;
            this.purchasehistoryUC1.Location = new System.Drawing.Point(19, 53);
            this.purchasehistoryUC1.Name = "purchasehistoryUC1";
            this.purchasehistoryUC1.Size = new System.Drawing.Size(776, 426);
            this.purchasehistoryUC1.TabIndex = 24;
            this.purchasehistoryUC1.Visible = false;
            // 
            // signUpUC1
            // 
            this.signUpUC1.BackColor = System.Drawing.Color.White;
            this.signUpUC1.Location = new System.Drawing.Point(292, 90);
            this.signUpUC1.Name = "signUpUC1";
            this.signUpUC1.Size = new System.Drawing.Size(507, 389);
            this.signUpUC1.TabIndex = 22;
            this.signUpUC1.Visible = false;
            // 
            // loginUC1
            // 
            this.loginUC1.BackColor = System.Drawing.Color.White;
            this.loginUC1.Location = new System.Drawing.Point(535, 90);
            this.loginUC1.Name = "loginUC1";
            this.loginUC1.Size = new System.Drawing.Size(260, 389);
            this.loginUC1.TabIndex = 21;
            this.loginUC1.Visible = false;
            this.loginUC1.VisibleChanged += new System.EventHandler(this.loginUC1_VisibleChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 497);
            this.Controls.Add(this.labelNiceToDeeYou);
            this.Controls.Add(this.purchasehistoryUC1);
            this.Controls.Add(this.signUpUC1);
            this.Controls.Add(this.loginUC1);
            this.Controls.Add(this.pesonalInfoUC1);
            this.Controls.Add(this.advatesingMoreInformation1);
            this.Controls.Add(this.advatesingMoreInformation2);
            this.Controls.Add(this.advatesingMoreInformation3);
            this.Controls.Add(this.advatisingUC1);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.Massage);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.labelNeedToSignIN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "MainForm";
            this.Text = "Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Label Massage;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Label labelNeedToSignIN;
        private System.Windows.Forms.Label labelNiceToDeeYou;
        private AdvatisingUC advatisingUC1;
        private AdvatesingMoreInformation advatesingMoreInformation1;
        private AdvatesingMoreInformation advatesingMoreInformation2;
        private AdvatesingMoreInformation advatesingMoreInformation3;
        private LoginUC loginUC1;
        private SignUpUC signUpUC1;
        private PesonalInfoUC pesonalInfoUC1;
        private PurchasehistoryUC purchasehistoryUC1;
    }
}

