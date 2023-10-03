using OKR_Twitter.Interfaces;
using OKR_Twitter.Models;
using OKR_Twitter.Models.DTOs;
using OKR_Twitter.Models.Entities;
using OKR_Twitter.Models.RequestModels;

namespace OKR_Twitter.Business
{
    public class RegisterBusiness : IRegisterBusiness
    {
        private readonly IRegisterDataAccess _registerDataAccess;
        public RegisterBusiness(IRegisterDataAccess registerDataAccess)
        {
            _registerDataAccess = registerDataAccess;
        }

        public ProcessResult<RegisterResponse> Register(RegisterRequestModel registerRequestModel)
        {
            var response = new ProcessResult<RegisterResponse>();

            var registerEntity = new RegisterEntity
            {
                UserId = Guid.NewGuid(),
                UserMail = registerRequestModel.UserMail,
                UserName = registerRequestModel.UserName,
                UserPassword = registerRequestModel.UserPassword,
                UserSecretCode = registerRequestModel.UserSecretCode
            };


            var data = _registerDataAccess.Register(registerEntity);
            response.Result = new RegisterResponse
            {
                UserId = data.Result.UserId.ToString(),
                UserMail = data.Result.UserMail,
                UserName = data.Result.UserName,
            };
            response.HasError = data.HasError;
            response.ErrorDescription = data.ErrorDescription;


            return response;
        }
    }
}
