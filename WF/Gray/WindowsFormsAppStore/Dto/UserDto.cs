using System;

namespace Dto
{
    public sealed class UserDto
    {
        public string Nickname { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public long? PhoneNumber { get; set; }
        public DateTime BornDate { get; set; }
        public string Address { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public UserDto(string nickname, string password, string name, string surname, long phoneNumber, DateTime bornDate, string address, string question, string answer)
        {
            Nickname = nickname; Password = password; Name = name; Surname = surname; PhoneNumber = phoneNumber; BornDate = bornDate; Address = address; Question = question; Answer = answer;
        }
        public override string ToString()
        {
            return "User:\n"
                 + "\t(nickname = " + Nickname + ",\n"
                 + "\tPassword = " + Password + "\n"
                 + "\tName = " + Name + "\n"
                 + "\tSurname = " + Surname + "\n"
                 + "\tPhoneNumber = " + PhoneNumber + "\n"
                 + "\tBornDate = " + BornDate + "\n"
                 + "\tAddress = " + Address + "\n"
                 + "\tQuestion = " + Question + "\n"
                 + "\tAnswer = " + Answer + ")";
        }
    }
}
