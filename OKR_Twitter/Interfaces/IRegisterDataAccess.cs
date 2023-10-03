using OKR_Twitter.Models;
using OKR_Twitter.Models.DatabaseTableModels;
using OKR_Twitter.Models.DTOs;
using OKR_Twitter.Models.Entities;

namespace OKR_Twitter.Interfaces
{
    public interface IRegisterDataAccess
    {
        public ProcessResult<UserLogin> Register(RegisterEntity registerEntity);
    }
}
