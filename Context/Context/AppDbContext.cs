using Microsoft.EntityFrameworkCore;
using Models.Models.DBModels;

namespace Context.Context
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
