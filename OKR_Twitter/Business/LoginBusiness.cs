using OKR_Twitter.Interfaces;
using OKR_Twitter.Models.DTOs;
using OKR_Twitter.Models.Entities;
using OKR_Twitter.Models.RequestModels;

namespace OKR_Twitter.Business
{
    public class LoginBusiness : ILoginBusiness
    {
        private readonly ILoginDataAccess _loginDataAccess;

        public LoginBusiness(ILoginDataAccess loginDataAccess)
        {
            _loginDataAccess = loginDataAccess;
        }

        public LoginResponse Login(LoginRequestModel loginRequestModel)
        {
            var loginEntity = new LoginEntity
            {
                UserMail = loginRequestModel.UserMail,
                UserName = loginRequestModel.UserName,
                UserPassword = loginRequestModel.UserPassword,
                UserSecretCode = loginRequestModel.UserSecretCode
            };
            var returnData = _loginDataAccess.Login(loginEntity);

            if (returnData == null) return new LoginResponse();
            else return returnData;
        }
    }
}
