using Dto;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Bll.Abstract;
using Bll.Concrete;
using System.Drawing;

namespace WindowsFormsAppStore
{
    public partial class AdvatisingUC : MetroFramework.Controls.MetroUserControl
    {
        List<AdvertisingDto> Advertisings = new List<AdvertisingDto>();
        readonly IAdvertisingBll AdvertisingBll = new AdvertisingBll();
        public AdvatisingUC()
        { 
            InitializeComponent();
        }
        public void SetTags(List<string> tags)
        {
            if (tags != null)
            {
                Advertisings = AdvertisingBll.GetAdvertising(tags);
            }
            else
            {
                Advertisings = AdvertisingBll.GetAdvertising();
            }
            labelCost1.Text = Convert.ToString(Advertisings[0].Cost) + "$";
            labelCost2.Text = Convert.ToString(Advertisings[1].Cost) + "$";
            labelCost3.Text = Convert.ToString(Advertisings[2].Cost) + "$";
            labelName1.Text = Advertisings[0].Purchase;
            labelName2.Text = Advertisings[1].Purchase;
            labelName3.Text = Advertisings[2].Purchase;
            advatesingMoreInformation3.SetAdwartisingDto(Advertisings[2]);
            advatesingMoreInformation2.SetAdwartisingDto(Advertisings[1]);
            advatesingMoreInformation1.SetAdwartisingDto(Advertisings[0]);
            pictureBoxAdvtesing1.Image = Image.FromFile(@"..\..\Pictures" + Advertisings[0].Picture);
            pictureBoxAdvtesing2.Image = Image.FromFile(@"..\..\Pictures" + Advertisings[1].Picture);
            pictureBoxAdvtesing3.Image = Image.FromFile(@"..\..\Pictures" + Advertisings[2].Picture);
        }
       
        private void pictureBoxAdvtesing1_Click(object sender, EventArgs e)
        {
            advatesingMoreInformation1.Visible = true;
        }

        private void pictureBoxAdvtesing2_Click(object sender, EventArgs e)
        {
            advatesingMoreInformation2.Visible = true;
        }

        private void pictureBoxAdvtesing3_Click(object sender, EventArgs e)
        {
            advatesingMoreInformation3.Visible = true;
        }

        private void pictureBoxAdvtesing1_Click_1(object sender, EventArgs e)
        {
            advatesingMoreInformation1.Visible = true;
        }
    }
}
