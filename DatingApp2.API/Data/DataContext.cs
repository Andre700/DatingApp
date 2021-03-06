using DatingApp.API.Models;
using DatingApp2.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp2.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options ) : base(options)
        {
        }

        public DbSet<Value> Values { get; set; }
        public DbSet<Users> Users { get; set; } 
        public DbSet<Photo> Photos { get; set; }
    }
}