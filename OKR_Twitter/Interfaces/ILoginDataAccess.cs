using OKR_Twitter.Models.DTOs;
using OKR_Twitter.Models.Entities;

namespace OKR_Twitter.Interfaces
{
    public interface ILoginDataAccess
    {
        public LoginResponse Login(LoginEntity loginEntity);
    }
}
