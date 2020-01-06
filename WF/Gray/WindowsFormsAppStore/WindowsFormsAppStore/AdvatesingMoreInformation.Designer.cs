namespace WindowsFormsAppStore
{
    partial class AdvatesingMoreInformation
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
            this.labelCost = new System.Windows.Forms.Label();
            this.labelPurchose = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxInformation = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCost.Location = new System.Drawing.Point(20, 36);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(45, 20);
            this.labelCost.TabIndex = 0;
            this.labelCost.Text = "cost";
            // 
            // labelPurchose
            // 
            this.labelPurchose.AutoSize = true;
            this.labelPurchose.BackColor = System.Drawing.Color.White;
            this.labelPurchose.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPurchose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPurchose.Location = new System.Drawing.Point(0, -1);
            this.labelPurchose.Name = "labelPurchose";
            this.labelPurchose.Size = new System.Drawing.Size(84, 27);
            this.labelPurchose.TabIndex = 3;
            this.labelPurchose.Text = "Label1";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.DarkRed;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.ForeColor = System.Drawing.Color.Firebrick;
            this.buttonClose.Location = new System.Drawing.Point(211, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 30);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxInformation
            // 
            this.textBoxInformation.BackColor = System.Drawing.Color.White;
            this.textBoxInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxInformation.Location = new System.Drawing.Point(10, 76);
            this.textBoxInformation.Multiline = true;
            this.textBoxInformation.Name = "textBoxInformation";
            this.textBoxInformation.ReadOnly = true;
            this.textBoxInformation.Size = new System.Drawing.Size(222, 275);
            this.textBoxInformation.TabIndex = 7;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelInfo.Location = new System.Drawing.Point(154, 56);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(78, 17);
            this.labelInfo.TabIndex = 8;
            this.labelInfo.Text = "Information";
            // 
            // AdvatesingMoreInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxInformation);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelPurchose);
            this.Controls.Add(this.labelCost);
            this.Name = "AdvatesingMoreInformation";
            this.Size = new System.Drawing.Size(240, 362);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelPurchose;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxInformation;
        private System.Windows.Forms.Label labelInfo;
    }
}
