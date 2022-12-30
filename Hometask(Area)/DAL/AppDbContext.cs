using Hometask_Area_.Models;
using Microsoft.EntityFrameworkCore;

namespace Hometask_Area_.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Employee> employees { get; set; }
    }
}
