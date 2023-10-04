using Context.Context;
using Interfaces.Interfaces;
using Models.Models;
using Models.Models.DBModels;
using Models.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataAccess
{
    public class RegisterDataAccess : IRegisterDataAccess
    {
        private readonly AppDbContext _context;
        public RegisterDataAccess(AppDbContext context)
        {
            _context = context;
        }
        public bool CheckDatabaseConnection()
        {
            var dbConnection = _context.Database.CanConnect();
            return _context.Database.CanConnect();
        }

        ProcessResult<UserLogin> IRegisterDataAccess.Register(RegisterEntity registerEntity)
        {
            ProcessResult<UserLogin> response = new ProcessResult<UserLogin>();
            UserLogin userLogin = new UserLogin();
            if (CheckDatabaseConnection())
            {
                userLogin.UserMail = registerEntity.UserMail;
                userLogin.UserSecretCode = registerEntity.UserSecretCode;
                userLogin.UserName = registerEntity.UserName;
                userLogin.UserId = registerEntity.UserId;
                userLogin.UserPassword = registerEntity.UserPassword;

                _context.UserLogin.Add(userLogin);
                _context.SaveChanges();

                response.ErrorDescription = "No Error";
                response.HasError = false;
                response.Result = userLogin;
            }
            else
            {
                response.HasError = true;
                response.ErrorDescription = "Error On Registration";
            }
            return response;
        }
    }
}
