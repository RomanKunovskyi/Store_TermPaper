namespace WindowsFormsAppStore
{
    partial class PesonalInfoUC
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelBornDate = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelSpeciaQuestion = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.Green;
            this.labelName.Location = new System.Drawing.Point(37, 61);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 18);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "label1";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.ForeColor = System.Drawing.Color.Green;
            this.labelSurname.Location = new System.Drawing.Point(61, 79);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(52, 18);
            this.labelSurname.TabIndex = 1;
            this.labelSurname.Text = "label2";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress.ForeColor = System.Drawing.Color.Green;
            this.labelAddress.Location = new System.Drawing.Point(17, 180);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(52, 18);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "label3";
            // 
            // labelBornDate
            // 
            this.labelBornDate.AutoSize = true;
            this.labelBornDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBornDate.ForeColor = System.Drawing.Color.Green;
            this.labelBornDate.Location = new System.Drawing.Point(17, 146);
            this.labelBornDate.Name = "labelBornDate";
            this.labelBornDate.Size = new System.Drawing.Size(52, 18);
            this.labelBornDate.TabIndex = 3;
            this.labelBornDate.Text = "label4";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhoneNumber.ForeColor = System.Drawing.Color.Green;
            this.labelPhoneNumber.Location = new System.Drawing.Point(17, 198);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(52, 18);
            this.labelPhoneNumber.TabIndex = 4;
            this.labelPhoneNumber.Text = "label5";
            // 
            // labelSpeciaQuestion
            // 
            this.labelSpeciaQuestion.AutoSize = true;
            this.labelSpeciaQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpeciaQuestion.ForeColor = System.Drawing.Color.Green;
            this.labelSpeciaQuestion.Location = new System.Drawing.Point(6, 32);
            this.labelSpeciaQuestion.Name = "labelSpeciaQuestion";
            this.labelSpeciaQuestion.Size = new System.Drawing.Size(46, 18);
            this.labelSpeciaQuestion.TabIndex = 5;
            this.labelSpeciaQuestion.Text = "label6";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.ForeColor = System.Drawing.Color.Green;
            this.labelLogin.Location = new System.Drawing.Point(14, 7);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(99, 32);
            this.labelLogin.TabIndex = 6;
            this.labelLogin.Text = "label7";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(217, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.labelSpeciaQuestion);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(3, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 67);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Special question";
            // 
            // PesonalInfoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelBornDate);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Name = "PesonalInfoUC";
            this.Size = new System.Drawing.Size(258, 389);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelBornDate;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelSpeciaQuestion;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
