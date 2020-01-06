using Bll.Abstract;
using DalFactory;
using Dto;
using Entity.Concrete;
using System.Security.Cryptography;
using System.Text;

namespace Bll.Concrete
{
    public class UserBll: IUserBll
    {

        public bool CompareAnswer(string answer, string nickname) //2 if true change password
        {
            UserEntity UEntity = FactorySingleton.GetDal().Dal.User().GetByFieldName("nickname", nickname)[0];
            return FactorySingleton.GetDal().Dal.SpecialQuestion().GetById(UEntity.ID.Value).Answer == answer;
        }

        public string GetSpesialQuestion(string nickname)// 1 user get question, set answer
        {
            UserEntity UEntity = FactorySingleton.GetDal().Dal.User().GetByFieldName("nickname", nickname)[0];
            return FactorySingleton.GetDal().Dal.SpecialQuestion().GetById(UEntity.ID.Value).Question;
        }

        public int ChangePassword(string nickname, string answer,string newPassword) //3 change password
        {
            try
            {
                if (CompareAnswer(answer, nickname))
                {
                    UserEntity UEntity = FactorySingleton.GetDal().Dal.User().GetByFieldName("nickname", nickname)[0];
                    FactorySingleton.GetDal().Dal.User().UpdateByFieldName("password", GetMD5(newPassword), "id", UEntity.ID.Value);
                    return 1;
                }
                return 0;
            }
            catch
            {
                return 0;
            }
        }

        public UserDto SignIn(string nickname, string password)
        {
            try
            {
                UserEntity UEntity = FactorySingleton.GetDal().Dal.User().GetByFieldName("nickname", nickname)[0];
                if (UEntity.Password == GetMD5(password))
                {
                    PersonEntity PEntity = FactorySingleton.GetDal().Dal.Person().GetById(UEntity.ID.Value);
                    SpecialQuestionEntity SQEntity = FactorySingleton.GetDal().Dal.SpecialQuestion().GetById(UEntity.ID.Value);
                    return new UserDto(UEntity.Nickname, UEntity.Password, PEntity.Name, PEntity.Surname, PEntity.PhoneNumber.Value, PEntity.BornDate, PEntity.Address, SQEntity.Question, SQEntity.Answer);
                }
                else
                {
                    return null;
                }

            }
            catch
            {
                return null;
            }
        }

        public int SignUp(UserDto InfoDto)
        {
            long id=-1;
            try
            {
                FactorySingleton.GetDal().Dal.User().Insert(new UserEntity(InfoDto.Nickname, GetMD5(InfoDto.Password)));
                id = FactorySingleton.GetDal().Dal.User().GetByFieldName("nickname", InfoDto.Nickname)[0].ID.Value;
                FactorySingleton.GetDal().Dal.Person().Insert(new PersonEntity(id, InfoDto.Name, InfoDto.Surname, InfoDto.PhoneNumber.Value, InfoDto.BornDate, InfoDto.Address));
                FactorySingleton.GetDal().Dal.SpecialQuestion().Insert(new SpecialQuestionEntity(id, InfoDto.Question, InfoDto.Answer));
                return 1;
            }
            catch
            {
                if (id != -1)
                {
                    if (FactorySingleton.GetDal().Dal.User().GetById(id) != null)
                    {

                        FactorySingleton.GetDal().Dal.SpecialQuestion().DeleteById(id);

                        FactorySingleton.GetDal().Dal.Person().DeleteById(id);

                        FactorySingleton.GetDal().Dal.User().DeleteById(id);
                    }
                }

                return 0;
            }
        }
        //using System.Security.Cryptography;
        private string GetMD5(string str)
        {
            string hash;
            using (MD5 md5Hash = MD5.Create())
            {
                hash = GetMd5Hash(md5Hash, str);
            }
            return hash;
        }
        private string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public bool LoginIsFree(string nickname)
        {
            if(FactorySingleton.GetDal().Dal.User().GetByFieldName("nickname", nickname).Count>0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
