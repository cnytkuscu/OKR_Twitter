using OKR_Twitter.Models;
using OKR_Twitter.Models.DTOs;
using OKR_Twitter.Models.RequestModels;

namespace OKR_Twitter.Interfaces
{
    public interface IRegisterBusiness
    {
        public ProcessResult<RegisterResponse> Register(RegisterRequestModel registerRequestModel);
    }
}
