using System;
using System.Windows.Forms;
using Dto;

namespace WindowsFormsAppStore
{
    public partial class PesonalInfoUC : MetroFramework.Controls.MetroUserControl
    {
        public PesonalInfoUC()
        {
            InitializeComponent();
        }
        public void SetInfo(UserDto userDto)
        {
            labelLogin.Text = userDto.Nickname;
            labelName.Text = userDto.Name;
            labelSurname.Text = userDto.Surname;
            labelAddress.Text = userDto.Address;
            labelPhoneNumber.Text = "+380"+Convert.ToString(userDto.PhoneNumber);
            labelBornDate.Text = "Born in " + Convert.ToString(userDto.BornDate.ToShortDateString());
            labelSpeciaQuestion.Text = userDto.Question;
        }
        public void SetDefoult()
        {
            labelLogin.Text = "";
            labelName.Text = "";
            labelSurname.Text = "";
            labelAddress.Text = "";
            labelPhoneNumber.Text = "";
            labelBornDate.Text = "";
            labelSpeciaQuestion.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetDefoult();
            this.Visible = false;
        }
    }
}
