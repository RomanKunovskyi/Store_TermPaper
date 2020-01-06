namespace WindowsFormsAppStore
{
    partial class SignUpUC
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelPhoneNum = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelBornDate = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelRepeatPassword = new System.Windows.Forms.Label();
            this.labelSpecialQuestion = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.dateTimePickerBornDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxRepeatPasswort = new System.Windows.Forms.TextBox();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.textBoxAnswear = new System.Windows.Forms.TextBox();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.DarkRed;
            this.buttonClose.Location = new System.Drawing.Point(462, 13);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 30);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial Narrow", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(75, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(37, 17);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Name";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Arial Narrow", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(57, 57);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(55, 17);
            this.labelSurname.TabIndex = 14;
            this.labelSurname.Text = "Surname";
            // 
            // labelPhoneNum
            // 
            this.labelPhoneNum.AutoSize = true;
            this.labelPhoneNum.Font = new System.Drawing.Font("Arial Narrow", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhoneNum.Location = new System.Drawing.Point(26, 124);
            this.labelPhoneNum.Name = "labelPhoneNum";
            this.labelPhoneNum.Size = new System.Drawing.Size(86, 17);
            this.labelPhoneNum.TabIndex = 15;
            this.labelPhoneNum.Text = "Phone number";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Arial Narrow", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress.Location = new System.Drawing.Point(60, 92);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(52, 17);
            this.labelAddress.TabIndex = 16;
            this.labelAddress.Text = "Address";
            // 
            // labelBornDate
            // 
            this.labelBornDate.AutoSize = true;
            this.labelBornDate.Font = new System.Drawing.Font("Arial Narrow", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBornDate.Location = new System.Drawing.Point(51, 156);
            this.labelBornDate.Name = "labelBornDate";
            this.labelBornDate.Size = new System.Drawing.Size(60, 17);
            this.labelBornDate.TabIndex = 17;
            this.labelBornDate.Text = "Born date";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Arial Narrow", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(7, 22);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(39, 17);
            this.labelLogin.TabIndex = 18;
            this.labelLogin.Text = "Login";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Arial Narrow", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(7, 84);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(61, 17);
            this.labelPassword.TabIndex = 19;
            this.labelPassword.Text = "Password";
            // 
            // labelRepeatPassword
            // 
            this.labelRepeatPassword.AutoSize = true;
            this.labelRepeatPassword.Font = new System.Drawing.Font("Arial Narrow", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRepeatPassword.Location = new System.Drawing.Point(7, 133);
            this.labelRepeatPassword.Name = "labelRepeatPassword";
            this.labelRepeatPassword.Size = new System.Drawing.Size(101, 17);
            this.labelRepeatPassword.TabIndex = 20;
            this.labelRepeatPassword.Text = "Repeat Password";
            // 
            // labelSpecialQuestion
            // 
            this.labelSpecialQuestion.AutoSize = true;
            this.labelSpecialQuestion.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpecialQuestion.Location = new System.Drawing.Point(6, 29);
            this.labelSpecialQuestion.Name = "labelSpecialQuestion";
            this.labelSpecialQuestion.Size = new System.Drawing.Size(231, 17);
            this.labelSpecialQuestion.TabIndex = 21;
            this.labelSpecialQuestion.Text = "Special Question (for password restoring)";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(118, 25);
            this.textBoxName.MaxLength = 12;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(182, 26);
            this.textBoxName.TabIndex = 22;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(118, 57);
            this.textBoxSurname.MaxLength = 12;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(182, 26);
            this.textBoxSurname.TabIndex = 23;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(118, 124);
            this.textBoxPhoneNumber.MaxLength = 10;
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(182, 26);
            this.textBoxPhoneNumber.TabIndex = 24;
            this.textBoxPhoneNumber.TextChanged += new System.EventHandler(this.textBoxPhoneNumber_TextChanged);
            this.textBoxPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(10, 42);
            this.textBoxLogin.MaxLength = 12;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(135, 26);
            this.textBoxLogin.TabIndex = 25;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(118, 92);
            this.textBoxAddress.MaxLength = 12;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(182, 26);
            this.textBoxAddress.TabIndex = 26;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged);
            // 
            // dateTimePickerBornDate
            // 
            this.dateTimePickerBornDate.Location = new System.Drawing.Point(118, 156);
            this.dateTimePickerBornDate.Name = "dateTimePickerBornDate";
            this.dateTimePickerBornDate.Size = new System.Drawing.Size(182, 26);
            this.dateTimePickerBornDate.TabIndex = 27;
            this.dateTimePickerBornDate.ValueChanged += new System.EventHandler(this.dateTimePickerBornDate_ValueChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(10, 104);
            this.textBoxPassword.MaxLength = 12;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(135, 26);
            this.textBoxPassword.TabIndex = 28;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // textBoxRepeatPasswort
            // 
            this.textBoxRepeatPasswort.Location = new System.Drawing.Point(10, 156);
            this.textBoxRepeatPasswort.MaxLength = 12;
            this.textBoxRepeatPasswort.Name = "textBoxRepeatPasswort";
            this.textBoxRepeatPasswort.PasswordChar = '*';
            this.textBoxRepeatPasswort.Size = new System.Drawing.Size(135, 26);
            this.textBoxRepeatPasswort.TabIndex = 29;
            this.textBoxRepeatPasswort.TextChanged += new System.EventHandler(this.textBoxRepeatPasswort_TextChanged);
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(6, 49);
            this.textBoxQuestion.MaxLength = 50;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(452, 26);
            this.textBoxQuestion.TabIndex = 30;
            this.textBoxQuestion.TextChanged += new System.EventHandler(this.textBoxQuestion_TextChanged);
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Font = new System.Drawing.Font("Arial Narrow", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAnswer.Location = new System.Drawing.Point(6, 81);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(48, 17);
            this.labelAnswer.TabIndex = 31;
            this.labelAnswer.Text = "Answer";
            // 
            // textBoxAnswear
            // 
            this.textBoxAnswear.Location = new System.Drawing.Point(63, 81);
            this.textBoxAnswear.MaxLength = 12;
            this.textBoxAnswear.Name = "textBoxAnswear";
            this.textBoxAnswear.Size = new System.Drawing.Size(395, 26);
            this.textBoxAnswear.TabIndex = 32;
            this.textBoxAnswear.TextChanged += new System.EventHandler(this.textBoxAnswear_TextChanged);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignUp.ForeColor = System.Drawing.Color.White;
            this.buttonSignUp.Location = new System.Drawing.Point(361, 13);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(92, 30);
            this.buttonSignUp.TabIndex = 34;
            this.buttonSignUp.Text = "Sign up";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.labelAddress);
            this.groupBox1.Controls.Add(this.labelSurname);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelPhoneNum);
            this.groupBox1.Controls.Add(this.labelBornDate);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.textBoxSurname);
            this.groupBox1.Controls.Add(this.dateTimePickerBornDate);
            this.groupBox1.Controls.Add(this.textBoxPhoneNumber);
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(16, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 193);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.textBoxAnswear);
            this.groupBox2.Controls.Add(this.textBoxQuestion);
            this.groupBox2.Controls.Add(this.labelSpecialQuestion);
            this.groupBox2.Controls.Add(this.labelAnswer);
            this.groupBox2.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(16, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 130);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spicial question information";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.labelLogin);
            this.groupBox3.Controls.Add(this.labelPassword);
            this.groupBox3.Controls.Add(this.labelRepeatPassword);
            this.groupBox3.Controls.Add(this.textBoxRepeatPasswort);
            this.groupBox3.Controls.Add(this.textBoxLogin);
            this.groupBox3.Controls.Add(this.textBoxPassword);
            this.groupBox3.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Location = new System.Drawing.Point(337, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 193);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "User Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "Enter infgormation. After that push \"Sign in\".";
            // 
            // SignUpUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.buttonClose);
            this.Name = "SignUpUC";
            this.Size = new System.Drawing.Size(507, 389);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelPhoneNum;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelBornDate;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelRepeatPassword;
        private System.Windows.Forms.Label labelSpecialQuestion;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.DateTimePicker dateTimePickerBornDate;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxRepeatPasswort;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.TextBox textBoxAnswear;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
    }
}
