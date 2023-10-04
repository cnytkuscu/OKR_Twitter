using Models.Models.DTO;
using Models.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    public interface ILoginDataAccess
    {
        public LoginResponse Login(LoginEntity loginEntity);
    }
}
