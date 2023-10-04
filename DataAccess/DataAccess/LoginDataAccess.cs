using Context.Context;
using Interfaces.Interfaces;
using Mappers;
using Models.Models.DTO;
using Models.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataAccess
{
    public class LoginDataAccess : ILoginDataAccess
    {
        private readonly AppDbContext _context;
        public LoginDataAccess(AppDbContext context)
        {
            _context = context;
        }
        public bool CheckDatabaseConnection()
        {
            var dbConnection = _context.Database.CanConnect();
            return _context.Database.CanConnect();
        }
        public LoginResponse Login(LoginEntity loginEntity)
        {
            LoginResponse response = new LoginResponse();
            if (CheckDatabaseConnection())
            {
                if (loginEntity.UserName != string.Empty)
                {
                    var returnData = _context.UserLogin.FirstOrDefault(x => x.UserName == loginEntity.UserName && x.UserPassword == loginEntity.UserPassword);
                    return new UserLoginToLoginResponse(returnData).Result;
                }
                if (loginEntity.UserMail != string.Empty)
                {
                    var returnData = _context.UserLogin.FirstOrDefault(x => x.UserMail == loginEntity.UserMail && x.UserPassword == loginEntity.UserPassword);
                    return new UserLoginToLoginResponse(returnData).Result;
                }
            }

            return new LoginResponse();
        }
    }
}
