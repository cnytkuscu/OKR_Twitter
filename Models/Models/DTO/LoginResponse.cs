using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.DTO
{
    public class LoginResponse
    {
        public LoginResponse()
        {
            UserId = "999";
            UserName = "Empty User";
            LoginSuccessfull = false;
            HasError = false;
        }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public bool LoginSuccessfull { get; set; }
        public bool HasError { get; set; }
    }
}
