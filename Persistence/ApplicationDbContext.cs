using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Persistence.Interface;

namespace Persistence
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) 
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string mySqlConnectionStr = this._configuration.GetConnectionString("Default") ?? "";
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseMySql(
            //       mySqlConnectionStr,
            //       ServerVersion.AutoDetect(mySqlConnectionStr),
            //       options => options.EnableRetryOnFailure(
            //           maxRetryCount: 5,
            //           maxRetryDelay: TimeSpan.FromSeconds(30),
            //           errorNumbersToAdd: null)
            //       );
            //}
            optionsBuilder.UseMySql(
                   mySqlConnectionStr,
                   ServerVersion.AutoDetect(mySqlConnectionStr),
                   options => options.EnableRetryOnFailure(
                       maxRetryCount: 5,
                       maxRetryDelay: TimeSpan.FromSeconds(30),
                       errorNumbersToAdd: null)
                   );
        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
