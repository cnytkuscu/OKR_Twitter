using Microsoft.EntityFrameworkCore;
using OKR_Twitter.Models;
using OKR_Twitter.Models.DatabaseTableModels;
using System.Collections.Generic;

namespace OKR_Twitter.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<UserDTM> User { get; set; }
        public DbSet<UserLogin> UserLogin { get; set; }


    }
}
