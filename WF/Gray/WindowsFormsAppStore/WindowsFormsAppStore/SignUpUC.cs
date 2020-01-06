using System;
using System.Drawing;
using System.Windows.Forms;
using Bll.Abstract;
using Bll.Concrete;
using Dto;

namespace WindowsFormsAppStore
{
    public partial class SignUpUC : MetroFramework.Controls.MetroUserControl
    {
        readonly IUserBll UserBll = new UserBll();
        public SignUpUC()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            bool signUp= true;

            string name = textBoxName.Text;
            if(name=="")
            {
                labelName.ForeColor = Color.DarkRed;
                signUp = false;
            }

            string surname = textBoxSurname.Text;
            if (surname == "")
            {
                labelSurname.ForeColor = Color.DarkRed;
                signUp = false;
            }

            string address = textBoxAddress.Text;
            if (address == "")
            {
                labelAddress.ForeColor = Color.DarkRed;
                signUp = false;
            }

            long phone_number=0;
            if (textBoxPhoneNumber.Text.Length!=9 && textBoxPhoneNumber.Text.Length != 10)
            {
                labelPhoneNum.ForeColor = Color.DarkRed;
                signUp = false;
            }

            else
            {
                phone_number = Convert.ToInt64(textBoxPhoneNumber.Text);
            }

            DateTime born_date = dateTimePickerBornDate.Value;

            string login = textBoxLogin.Text;
            if (textBoxLogin.Text.Length < 6)
            {
                labelLogin.ForeColor = Color.DarkRed;
                signUp = false;
            }

            string password = textBoxPassword.Text;
            if(textBoxPassword.Text.Length<6)
            {
                labelPassword.ForeColor = Color.DarkRed;
                signUp = false;
            }

            string repeat_password = textBoxRepeatPasswort.Text;
            if (repeat_password!=password)
            {
                labelRepeatPassword.ForeColor = Color.DarkRed;
                signUp = false;
            }

            string question = textBoxQuestion.Text;
            if (question == "")
            {
                labelSpecialQuestion.ForeColor = Color.DarkRed;
                signUp = false;
            }

            string answer = textBoxAnswear.Text;
            if (answer == "")
            {
                labelAnswer.ForeColor = Color.DarkRed;
                signUp = false;
            }

            if (signUp)
            {
                UserBll.SignUp(new UserDto(login, password, name, surname, phone_number, born_date, address, question, answer));
                SetDefoult();
                Visible = false;

            }
        }
        public void SetDefoult()
        {
            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxAddress.Text = "";
            textBoxPhoneNumber.Text = "";
            dateTimePickerBornDate.Value = DateTime.Today;
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
            textBoxRepeatPasswort.Text = "";
            textBoxQuestion.Text = "";
            textBoxAnswear.Text = "";
        }
        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            labelName.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {
            labelSurname.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            labelPhoneNum.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            labelAddress.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void dateTimePickerBornDate_ValueChanged(object sender, EventArgs e)
        {
            labelBornDate.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            labelLogin.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            labelPassword.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void textBoxRepeatPasswort_TextChanged(object sender, EventArgs e)
        {
            labelRepeatPassword.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void textBoxQuestion_TextChanged(object sender, EventArgs e)
        {
            labelSpecialQuestion.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void textBoxAnswear_TextChanged(object sender, EventArgs e)
        {
            labelAnswer.ForeColor = Color.FromArgb(64, 64, 64);
        }
    }
}
