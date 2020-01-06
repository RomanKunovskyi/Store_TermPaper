using Entity.Abstract.Interfaces;

namespace Entity.Concrete
{
    public enum EUserEntity
    {
        ID = 0,
        NICKNAME,
        PASSWORD
    }
    public sealed class UserEntity:IEntity
    {
        public long? ID { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        public UserEntity(string nickname, string password)
        {
            Nickname = nickname; Password = password;
        }
    }
}
