using JWTAuthentication.Models;
using Microsoft.EntityFrameworkCore;
using TestAPI;

namespace JWTAuthentication.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Superhero> Superheroes { get; set; }
    }
}
