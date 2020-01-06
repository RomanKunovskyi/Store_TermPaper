namespace WindowsFormsAppStore
{
    partial class RestorePasswordUC
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
            this.labelAskLogin = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.buttonAskLogin = new System.Windows.Forms.Button();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxRepeatPassword = new System.Windows.Forms.TextBox();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxQestion = new System.Windows.Forms.TextBox();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAskLogin
            // 
            this.labelAskLogin.AutoSize = true;
            this.labelAskLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAskLogin.ForeColor = System.Drawing.Color.Green;
            this.labelAskLogin.Location = new System.Drawing.Point(20, 56);
            this.labelAskLogin.Name = "labelAskLogin";
            this.labelAskLogin.Size = new System.Drawing.Size(134, 17);
            this.labelAskLogin.TabIndex = 0;
            this.labelAskLogin.Text = "Enter your login. \r\n";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(23, 76);
            this.textBoxLogin.MaxLength = 12;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(174, 22);
            this.textBoxLogin.TabIndex = 1;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // buttonAskLogin
            // 
            this.buttonAskLogin.BackColor = System.Drawing.Color.Green;
            this.buttonAskLogin.ForeColor = System.Drawing.Color.White;
            this.buttonAskLogin.Location = new System.Drawing.Point(203, 71);
            this.buttonAskLogin.Name = "buttonAskLogin";
            this.buttonAskLogin.Size = new System.Drawing.Size(48, 32);
            this.buttonAskLogin.TabIndex = 2;
            this.buttonAskLogin.Text = "Next";
            this.buttonAskLogin.UseVisualStyleBackColor = false;
            this.buttonAskLogin.Click += new System.EventHandler(this.buttonAskLogin_Click);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(23, 178);
            this.textBoxAnswer.MaxLength = 12;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.ReadOnly = true;
            this.textBoxAnswer.Size = new System.Drawing.Size(174, 22);
            this.textBoxAnswer.TabIndex = 4;
            this.textBoxAnswer.TextChanged += new System.EventHandler(this.textBoxanswer_TextChanged);
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.BackColor = System.Drawing.Color.Green;
            this.buttonAnswer.ForeColor = System.Drawing.Color.White;
            this.buttonAnswer.Location = new System.Drawing.Point(203, 173);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(48, 32);
            this.buttonAnswer.TabIndex = 5;
            this.buttonAnswer.Text = "Next";
            this.buttonAnswer.UseVisualStyleBackColor = false;
            this.buttonAnswer.Visible = false;
            this.buttonAnswer.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.Green;
            this.buttonChange.ForeColor = System.Drawing.Color.White;
            this.buttonChange.Location = new System.Drawing.Point(203, 239);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(48, 51);
            this.buttonChange.TabIndex = 6;
            this.buttonChange.Text = "OK";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Visible = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(23, 240);
            this.textBoxPassword.MaxLength = 12;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.ReadOnly = true;
            this.textBoxPassword.Size = new System.Drawing.Size(174, 22);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // textBoxRepeatPassword
            // 
            this.textBoxRepeatPassword.Location = new System.Drawing.Point(23, 268);
            this.textBoxRepeatPassword.MaxLength = 12;
            this.textBoxRepeatPassword.Name = "textBoxRepeatPassword";
            this.textBoxRepeatPassword.PasswordChar = '*';
            this.textBoxRepeatPassword.ReadOnly = true;
            this.textBoxRepeatPassword.Size = new System.Drawing.Size(174, 22);
            this.textBoxRepeatPassword.TabIndex = 8;
            this.textBoxRepeatPassword.TextChanged += new System.EventHandler(this.textBoxRepeatPassword_TextChanged);
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewPassword.ForeColor = System.Drawing.Color.Green;
            this.labelNewPassword.Location = new System.Drawing.Point(20, 220);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(153, 17);
            this.labelNewPassword.TabIndex = 9;
            this.labelNewPassword.Text = "Enter new password";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.DarkRed;
            this.labelError.Location = new System.Drawing.Point(7, 237);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 17);
            this.labelError.TabIndex = 10;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(220, 13);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 30);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxQestion
            // 
            this.textBoxQestion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxQestion.ForeColor = System.Drawing.Color.Green;
            this.textBoxQestion.Location = new System.Drawing.Point(23, 114);
            this.textBoxQestion.Multiline = true;
            this.textBoxQestion.Name = "textBoxQestion";
            this.textBoxQestion.ReadOnly = true;
            this.textBoxQestion.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxQestion.Size = new System.Drawing.Size(228, 41);
            this.textBoxQestion.TabIndex = 12;
            this.textBoxQestion.Text = "The question is up to you.";
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAnswer.ForeColor = System.Drawing.Color.Green;
            this.labelAnswer.Location = new System.Drawing.Point(20, 158);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(60, 17);
            this.labelAnswer.TabIndex = 13;
            this.labelAnswer.Text = "Answer";
            // 
            // RestorePasswordUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.textBoxQestion);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelNewPassword);
            this.Controls.Add(this.textBoxRepeatPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonAnswer);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.buttonAskLogin);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelAskLogin);
            this.Name = "RestorePasswordUC";
            this.Size = new System.Drawing.Size(265, 389);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAskLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button buttonAskLogin;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxRepeatPassword;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxQestion;
        private System.Windows.Forms.Label labelAnswer;
    }
}
