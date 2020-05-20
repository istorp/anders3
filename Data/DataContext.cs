using anders3.Models;
using Microsoft.EntityFrameworkCore;

namespace anders3.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Character> Characters { get; set; }
        public DbSet<User> Users { get; set; }
    }
}