using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OKR_Twitter.Context;
using OKR_Twitter.Interfaces;
using OKR_Twitter.Mappers;
using OKR_Twitter.Models.DTOs;
using OKR_Twitter.Models.Entities;
using System.Data;
using System.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace OKR_Twitter.DataAccess
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
