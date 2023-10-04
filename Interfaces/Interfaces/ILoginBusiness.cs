using Models.Models.DTO;
using Models.Models.RequestModels;

namespace Interfaces.Interfaces
{
    public interface ILoginBusiness
    {
        public LoginResponse Login(LoginRequestModel loginRequestModel);
    }
}
