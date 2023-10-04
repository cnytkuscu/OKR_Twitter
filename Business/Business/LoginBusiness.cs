using Interfaces.Interfaces;
using Models.Models.DTO;
using Models.Models.Entities;
using Models.Models.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Business
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
