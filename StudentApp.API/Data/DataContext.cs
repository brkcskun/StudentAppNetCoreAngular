using Microsoft.EntityFrameworkCore;
using StudentApp.API.Models;

namespace StudentApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options) { }

        public DbSet<Value> Values { get; set; }

    }
}