using Dto;

namespace Bll.Abstract
{
    public interface IUserBll
    {
        UserDto SignIn(string nickname, string password);
        int SignUp(UserDto InfoDto);
        int ChangePassword(string nickname, string answer, string newPassword);
        bool CompareAnswer(string answer, string nickname);
        string GetSpesialQuestion(string nickname);
        bool LoginIsFree(string nickname);

    }
}
