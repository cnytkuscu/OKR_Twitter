using Models.Models;
using Models.Models.DBModels;
using Models.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    public interface IRegisterDataAccess
    {
        public ProcessResult<UserLogin> Register(RegisterEntity registerEntity);
    }
}
