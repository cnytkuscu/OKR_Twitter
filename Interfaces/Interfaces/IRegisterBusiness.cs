using Models.Models;
using Models.Models.DTO;
using Models.Models.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    public interface IRegisterBusiness
    {
        public ProcessResult<RegisterResponse> Register(RegisterRequestModel registerRequestModel);
    }
}
