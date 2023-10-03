using Microsoft.EntityFrameworkCore;
using OKR_Twitter.Business;
using OKR_Twitter.Context;
using OKR_Twitter.DataAccess;
using OKR_Twitter.Interfaces;
using System;

namespace OKR_Twitter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));

            builder.Services.AddScoped<ILoginBusiness, LoginBusiness>();
            builder.Services.AddScoped<ILoginDataAccess, LoginDataAccess>();

            builder.Services.AddScoped<IRegisterBusiness, RegisterBusiness>();
            builder.Services.AddScoped<IRegisterDataAccess, RegisterDataAccess>();


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}