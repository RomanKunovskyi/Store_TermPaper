namespace WindowsFormsAppStore
{
    partial class LoginUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.buttonRestorePassword = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.restorePasswordUC1 = new WindowsFormsAppStore.RestorePasswordUC();
            this.SuspendLayout();
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.Color.Green;
            this.buttonSignIn.ForeColor = System.Drawing.Color.White;
            this.buttonSignIn.Location = new System.Drawing.Point(13, 122);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(96, 30);
            this.buttonSignIn.TabIndex = 1;
            this.buttonSignIn.Text = "Sign in";
            this.buttonSignIn.UseVisualStyleBackColor = false;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // buttonRestorePassword
            // 
            this.buttonRestorePassword.BackColor = System.Drawing.Color.Green;
            this.buttonRestorePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRestorePassword.ForeColor = System.Drawing.Color.White;
            this.buttonRestorePassword.Location = new System.Drawing.Point(115, 122);
            this.buttonRestorePassword.Name = "buttonRestorePassword";
            this.buttonRestorePassword.Size = new System.Drawing.Size(135, 30);
            this.buttonRestorePassword.TabIndex = 2;
            this.buttonRestorePassword.Text = "I forgot password";
            this.buttonRestorePassword.UseVisualStyleBackColor = false;
            this.buttonRestorePassword.Click += new System.EventHandler(this.buttonRestorePassword_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(13, 94);
            this.textBoxPassword.MaxLength = 12;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(237, 22);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(13, 49);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(237, 22);
            this.textBoxLogin.TabIndex = 4;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.ForeColor = System.Drawing.Color.Green;
            this.labelLogin.Location = new System.Drawing.Point(10, 29);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(48, 17);
            this.labelLogin.TabIndex = 5;
            this.labelLogin.Text = "Login";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.ForeColor = System.Drawing.Color.Green;
            this.labelPassword.Location = new System.Drawing.Point(10, 74);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(77, 17);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(220, 13);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 30);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // restorePasswordUC1
            // 
            this.restorePasswordUC1.BackColor = System.Drawing.Color.White;
            this.restorePasswordUC1.Location = new System.Drawing.Point(0, 0);
            this.restorePasswordUC1.Name = "restorePasswordUC1";
            this.restorePasswordUC1.Size = new System.Drawing.Size(265, 389);
            this.restorePasswordUC1.TabIndex = 9;
            this.restorePasswordUC1.Visible = false;
            // 
            // LoginUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.restorePasswordUC1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonRestorePassword);
            this.Controls.Add(this.buttonSignIn);
            this.Name = "LoginUC";
            this.Size = new System.Drawing.Size(265, 389);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Button buttonRestorePassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonClose;
        private RestorePasswordUC restorePasswordUC1;
    }
}
