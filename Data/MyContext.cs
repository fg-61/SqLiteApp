using Microsoft.EntityFrameworkCore;
using SqLiteApp.Models;

namespace SqLiteApp.Data
{
    public class MyContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=C:\SqLiteDb\User.db");
    }
}
