using System;
using System.Windows.Forms;
using Dto;

namespace WindowsFormsAppStore
{
    public partial class AdvatesingMoreInformation : MetroFramework.Controls.MetroUserControl
    {
        public AdvatesingMoreInformation()
        {
            InitializeComponent();
        }
        public void SetAdwartisingDto(AdvertisingDto Advertising)
        {
            textBoxInformation.Text = Advertising.Info;
            labelPurchose.Text = Advertising.Purchase;
            labelCost.Text = Convert.ToString(Advertising.Cost) + "$";
        }
       
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
