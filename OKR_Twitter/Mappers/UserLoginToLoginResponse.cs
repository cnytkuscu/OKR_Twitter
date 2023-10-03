using OKR_Twitter.Models.DatabaseTableModels;
using OKR_Twitter.Models.DTOs;

namespace OKR_Twitter.Mappers
{
    public class UserLoginToLoginResponse
    {
        public LoginResponse Result { get; set; }
        public UserLoginToLoginResponse(UserLogin userLogin)
        {
            Result = new LoginResponse();

            Result.UserId = userLogin.UserId.ToString();
            Result.UserName = userLogin.UserName.ToString();
        }
    }
}
