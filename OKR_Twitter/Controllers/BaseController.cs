using Microsoft.AspNetCore.Mvc;
using OKR_Twitter.Business;
using OKR_Twitter.Interfaces;
using OKR_Twitter.Models.RequestModels;

namespace OKR_Twitter.Controllers
{
    [ApiController]
    [Route("api/v1/[action]")]
    public class BaseController : Controller
    {
        private readonly ILoginBusiness _loginBusiness;
        private readonly IRegisterBusiness _registerBusiness;

        public BaseController(ILoginBusiness loginBusiness,IRegisterBusiness registerBusiness)
        {
            _loginBusiness = loginBusiness;
            _registerBusiness = registerBusiness;
        }

        [HttpPost]
        public IActionResult Login([FromBody] LoginRequestModel loginRequestModel)
        {
            var returnData = _loginBusiness.Login(loginRequestModel);
             
            if(returnData == null)
            {
                return NotFound();
            }
            else if(returnData.HasError)
            {
                return Problem();
            }
            else if(!returnData.LoginSuccessfull)
            {
                return BadRequest();
            }
            return Ok(returnData);
        }

        [HttpPost]
        public IActionResult Register([FromBody] RegisterRequestModel registerRequestModel)
        {
            var returnData = _registerBusiness.Register(registerRequestModel);

            if (returnData == null)
            {
                return NotFound();
            }
            else if (returnData.HasError)
            {
                return Problem();
            } 
            return Ok(returnData);
        }
    }
}
