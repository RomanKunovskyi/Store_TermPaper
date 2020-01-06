using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Bll.Abstract;
using Bll.Concrete;
using Dto;

namespace WindowsFormsAppStore
{
    public partial class PurchasehistoryUC : MetroFramework.Controls.MetroUserControl
    {
        IPurchaseHistoryBll PurchaseHistoryBll;
        public PurchasehistoryUC()
        {
            InitializeComponent();
        }
        private void ClearGrid()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns.Add("Cost", "Cost");
            dataGridView1.Columns[1].Width = 50;
            dataGridView1.Columns.Add("Type", "Type");
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns.Add("Barand", "Barand");
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Rows.Clear();
        }

        public void SetPurchaseHistoryBll(string login)
        {
            PurchaseHistoryBll = new PurchaseHistoryBll(login);
            ChangeInfoToGrid(PurchaseHistoryBll.GetList());
        }
        private  void ChangeInfoToGrid(List<PurchaseHistoryDto> List)
        {
            ClearGrid();
            if (List != null)
            {
                foreach(var el in List)
                {
                    dataGridView1.Rows.Add(el.Name, Convert.ToString(el.Cost)+"$", el.Type, el.Brand, Convert.ToString(el.Date));
                }

            }
            labelNum.Text = Convert.ToString(List.Count);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void buttonSortByType_Click(object sender, EventArgs e)
        {
            PurchaseHistoryBll.SortByType();
            ChangeInfoToGrid(PurchaseHistoryBll.GetList());  
        }

        private void buttonSortByCost_Click(object sender, EventArgs e)
        {
            PurchaseHistoryBll.SortByCost();
            ChangeInfoToGrid(PurchaseHistoryBll.GetList());
        }

        private void buttonSortByBrand_Click(object sender, EventArgs e)
        {
            PurchaseHistoryBll.SortByBrand();
            ChangeInfoToGrid(PurchaseHistoryBll.GetList());
        }

        private void buttonSortByDate_Click(object sender, EventArgs e)
        {
            PurchaseHistoryBll.SortByDate();
            ChangeInfoToGrid(PurchaseHistoryBll.GetList());
        }

        private void buttonSortByName_Click(object sender, EventArgs e)
        {
            PurchaseHistoryBll.SortByName();
            ChangeInfoToGrid(PurchaseHistoryBll.GetList());
        }

        private void textBoxFromCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBoxToCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void buttonDo_Click(object sender, EventArgs e)
        {
            PurchaseHistoryBll.ClearSortAndFilters();
            if (textBoxBrand.Text!="")
            {
                PurchaseHistoryBll.GetFilteredByBradList(textBoxBrand.Text);
                labelBrand.ForeColor = Color.FromArgb(64, 64, 64); 
            }
            else
            {
                labelBrand.ForeColor = Color.DarkRed;
            }
            if (textBoxType.Text != "")
            {
                PurchaseHistoryBll.GetFilteredByTypeList(textBoxType.Text);
                labelType.ForeColor = Color.FromArgb(64, 64, 64); 
            }
            else
            {
                labelType.ForeColor = Color.DarkRed;
            }
            if (textBoxName.Text != "")
            {
                PurchaseHistoryBll.GetFilteredByNameList(textBoxName.Text);
                labelName.ForeColor = Color.FromArgb(64, 64, 64); 
            }
            else
            {
                labelName.ForeColor = Color.DarkRed;
            }
            if (textBoxFromCost.Text != "" || textBoxToCost.Text != "")
            {
                
                if(textBoxFromCost.Text == "")
                {
                    textBoxFromCost.Text = "0";
                }
                if (textBoxToCost.Text == "")
                {
                    textBoxToCost.Text = "999999999";
                }
                PurchaseHistoryBll.GetFilteredByCostList(Convert.ToDouble(textBoxFromCost.Text), Convert.ToDouble(textBoxToCost.Text));
                labelCost.ForeColor = Color.FromArgb(64, 64, 64); 
            }
            else
            {
                labelCost.ForeColor = Color.DarkRed;
            }
            ChangeInfoToGrid(PurchaseHistoryBll.GetList());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetDefoult();
        }
        public void SetDefoult()
        {
            textBoxFromCost.Text = "";
            textBoxToCost.Text = "";
            textBoxType.Text = "";
            textBoxName.Text = "";
            textBoxBrand.Text = "";
            PurchaseHistoryBll.ClearSortAndFilters();
            ChangeInfoToGrid(PurchaseHistoryBll.GetList());
            labelCost.ForeColor = Color.DarkRed;
            labelName.ForeColor = Color.DarkRed;
            labelType.ForeColor = Color.DarkRed;
            labelBrand.ForeColor = Color.DarkRed;
        }
    }
}
