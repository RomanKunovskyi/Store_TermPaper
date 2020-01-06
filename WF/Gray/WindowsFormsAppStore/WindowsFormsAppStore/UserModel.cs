using System.Runtime.Serialization;


namespace WindowsFormsAppStore
{
    [DataContract]
    public class UserModel
    {
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Password { get; set; }
        public UserModel()
        {

        }
        public UserModel(string Login, string Password)
        {
            this.Login = Login;this.Password = Password;
        }
    }
}
