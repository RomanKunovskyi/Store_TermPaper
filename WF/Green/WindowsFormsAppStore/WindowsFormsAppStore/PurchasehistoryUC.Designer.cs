namespace WindowsFormsAppStore
{
    partial class PurchasehistoryUC
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
            this.groupBoxSort = new System.Windows.Forms.GroupBox();
            this.buttonSortByDate = new System.Windows.Forms.Button();
            this.buttonSortByBrand = new System.Windows.Forms.Button();
            this.buttonSortByType = new System.Windows.Forms.Button();
            this.buttonSortByCost = new System.Windows.Forms.Button();
            this.buttonSortByName = new System.Windows.Forms.Button();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDo = new System.Windows.Forms.Button();
            this.textBoxToCost = new System.Windows.Forms.TextBox();
            this.textBoxFromCost = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelNum = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxSort.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSort
            // 
            this.groupBoxSort.BackColor = System.Drawing.Color.White;
            this.groupBoxSort.Controls.Add(this.buttonSortByDate);
            this.groupBoxSort.Controls.Add(this.buttonSortByBrand);
            this.groupBoxSort.Controls.Add(this.buttonSortByType);
            this.groupBoxSort.Controls.Add(this.buttonSortByCost);
            this.groupBoxSort.Controls.Add(this.buttonSortByName);
            this.groupBoxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSort.ForeColor = System.Drawing.Color.Green;
            this.groupBoxSort.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSort.Name = "groupBoxSort";
            this.groupBoxSort.Size = new System.Drawing.Size(174, 86);
            this.groupBoxSort.TabIndex = 0;
            this.groupBoxSort.TabStop = false;
            this.groupBoxSort.Text = "Sort by";
            // 
            // buttonSortByDate
            // 
            this.buttonSortByDate.BackColor = System.Drawing.Color.Green;
            this.buttonSortByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSortByDate.ForeColor = System.Drawing.Color.White;
            this.buttonSortByDate.Location = new System.Drawing.Point(6, 55);
            this.buttonSortByDate.Name = "buttonSortByDate";
            this.buttonSortByDate.Size = new System.Drawing.Size(75, 25);
            this.buttonSortByDate.TabIndex = 4;
            this.buttonSortByDate.Text = "Date";
            this.buttonSortByDate.UseVisualStyleBackColor = false;
            this.buttonSortByDate.Click += new System.EventHandler(this.buttonSortByDate_Click);
            // 
            // buttonSortByBrand
            // 
            this.buttonSortByBrand.BackColor = System.Drawing.Color.Green;
            this.buttonSortByBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSortByBrand.ForeColor = System.Drawing.Color.White;
            this.buttonSortByBrand.Location = new System.Drawing.Point(87, 55);
            this.buttonSortByBrand.Name = "buttonSortByBrand";
            this.buttonSortByBrand.Size = new System.Drawing.Size(75, 25);
            this.buttonSortByBrand.TabIndex = 3;
            this.buttonSortByBrand.Text = "Brand";
            this.buttonSortByBrand.UseVisualStyleBackColor = false;
            this.buttonSortByBrand.Click += new System.EventHandler(this.buttonSortByBrand_Click);
            // 
            // buttonSortByType
            // 
            this.buttonSortByType.BackColor = System.Drawing.Color.Green;
            this.buttonSortByType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSortByType.ForeColor = System.Drawing.Color.White;
            this.buttonSortByType.Location = new System.Drawing.Point(85, 0);
            this.buttonSortByType.Name = "buttonSortByType";
            this.buttonSortByType.Size = new System.Drawing.Size(76, 25);
            this.buttonSortByType.TabIndex = 2;
            this.buttonSortByType.Text = "Type";
            this.buttonSortByType.UseVisualStyleBackColor = false;
            this.buttonSortByType.Click += new System.EventHandler(this.buttonSortByType_Click);
            // 
            // buttonSortByCost
            // 
            this.buttonSortByCost.BackColor = System.Drawing.Color.Green;
            this.buttonSortByCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSortByCost.ForeColor = System.Drawing.Color.White;
            this.buttonSortByCost.Location = new System.Drawing.Point(85, 26);
            this.buttonSortByCost.Name = "buttonSortByCost";
            this.buttonSortByCost.Size = new System.Drawing.Size(76, 25);
            this.buttonSortByCost.TabIndex = 1;
            this.buttonSortByCost.Text = "Cost";
            this.buttonSortByCost.UseVisualStyleBackColor = false;
            this.buttonSortByCost.Click += new System.EventHandler(this.buttonSortByCost_Click);
            // 
            // buttonSortByName
            // 
            this.buttonSortByName.BackColor = System.Drawing.Color.Green;
            this.buttonSortByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSortByName.ForeColor = System.Drawing.Color.White;
            this.buttonSortByName.Location = new System.Drawing.Point(6, 26);
            this.buttonSortByName.Name = "buttonSortByName";
            this.buttonSortByName.Size = new System.Drawing.Size(73, 25);
            this.buttonSortByName.TabIndex = 0;
            this.buttonSortByName.Text = "Name";
            this.buttonSortByName.UseVisualStyleBackColor = false;
            this.buttonSortByName.Click += new System.EventHandler(this.buttonSortByName_Click);
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.BackColor = System.Drawing.Color.White;
            this.groupBoxFilter.Controls.Add(this.labelCost);
            this.groupBoxFilter.Controls.Add(this.labelBrand);
            this.groupBoxFilter.Controls.Add(this.labelType);
            this.groupBoxFilter.Controls.Add(this.labelName);
            this.groupBoxFilter.Controls.Add(this.label2);
            this.groupBoxFilter.Controls.Add(this.label1);
            this.groupBoxFilter.Controls.Add(this.button2);
            this.groupBoxFilter.Controls.Add(this.buttonDo);
            this.groupBoxFilter.Controls.Add(this.textBoxToCost);
            this.groupBoxFilter.Controls.Add(this.textBoxFromCost);
            this.groupBoxFilter.Controls.Add(this.textBoxName);
            this.groupBoxFilter.Controls.Add(this.textBoxType);
            this.groupBoxFilter.Controls.Add(this.textBoxBrand);
            this.groupBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxFilter.ForeColor = System.Drawing.Color.Green;
            this.groupBoxFilter.Location = new System.Drawing.Point(183, 3);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(553, 86);
            this.groupBoxFilter.TabIndex = 1;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter by";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCost.ForeColor = System.Drawing.Color.Red;
            this.labelCost.Location = new System.Drawing.Point(356, 38);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(87, 17);
            this.labelCost.TabIndex = 12;
            this.labelCost.Text = "Product cost";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBrand.ForeColor = System.Drawing.Color.Red;
            this.labelBrand.Location = new System.Drawing.Point(235, 38);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(98, 17);
            this.labelBrand.TabIndex = 11;
            this.labelBrand.Text = "Product brand";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelType.ForeColor = System.Drawing.Color.Red;
            this.labelType.Location = new System.Drawing.Point(120, 38);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(88, 17);
            this.labelType.TabIndex = 10;
            this.labelType.Text = "Product type";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.Red;
            this.labelName.Location = new System.Drawing.Point(6, 38);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(96, 17);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Product name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(461, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(356, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "from";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(427, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Clear filters";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDo
            // 
            this.buttonDo.BackColor = System.Drawing.Color.Green;
            this.buttonDo.ForeColor = System.Drawing.Color.White;
            this.buttonDo.Location = new System.Drawing.Point(301, 1);
            this.buttonDo.Name = "buttonDo";
            this.buttonDo.Size = new System.Drawing.Size(120, 28);
            this.buttonDo.TabIndex = 5;
            this.buttonDo.Text = "Filter";
            this.buttonDo.UseVisualStyleBackColor = false;
            this.buttonDo.Click += new System.EventHandler(this.buttonDo_Click);
            // 
            // textBoxToCost
            // 
            this.textBoxToCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxToCost.Location = new System.Drawing.Point(489, 58);
            this.textBoxToCost.Name = "textBoxToCost";
            this.textBoxToCost.Size = new System.Drawing.Size(58, 22);
            this.textBoxToCost.TabIndex = 4;
            this.textBoxToCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxToCost_KeyPress);
            // 
            // textBoxFromCost
            // 
            this.textBoxFromCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFromCost.Location = new System.Drawing.Point(402, 58);
            this.textBoxFromCost.Name = "textBoxFromCost";
            this.textBoxFromCost.Size = new System.Drawing.Size(58, 22);
            this.textBoxFromCost.TabIndex = 3;
            this.textBoxFromCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFromCost_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(6, 58);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxType
            // 
            this.textBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxType.Location = new System.Drawing.Point(123, 58);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(100, 22);
            this.textBoxType.TabIndex = 1;
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBrand.Location = new System.Drawing.Point(238, 58);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(100, 22);
            this.textBoxBrand.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Location = new System.Drawing.Point(742, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(30, 30);
            this.buttonExit.TabIndex = 37;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNum.ForeColor = System.Drawing.Color.Green;
            this.labelNum.Location = new System.Drawing.Point(736, 406);
            this.labelNum.MinimumSize = new System.Drawing.Size(40, 20);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(40, 20);
            this.labelNum.TabIndex = 38;
            this.labelNum.Text = "12";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.Location = new System.Drawing.Point(3, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(770, 328);
            this.dataGridView1.TabIndex = 39;
            // 
            // PurchasehistoryUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.groupBoxSort);
            this.Name = "PurchasehistoryUC";
            this.Size = new System.Drawing.Size(776, 426);
            this.groupBoxSort.ResumeLayout(false);
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSort;
        private System.Windows.Forms.Button buttonSortByDate;
        private System.Windows.Forms.Button buttonSortByBrand;
        private System.Windows.Forms.Button buttonSortByType;
        private System.Windows.Forms.Button buttonSortByCost;
        private System.Windows.Forms.Button buttonSortByName;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxToCost;
        private System.Windows.Forms.TextBox textBoxFromCost;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDo;
    }
}
