using Models.Models.DBModels;
using Models.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers
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
