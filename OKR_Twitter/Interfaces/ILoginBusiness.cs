using OKR_Twitter.Models.DTOs;
using OKR_Twitter.Models.RequestModels;

namespace OKR_Twitter.Interfaces
{
    public interface ILoginBusiness
    {
        public LoginResponse Login(LoginRequestModel loginRequestModel);
    }
}
