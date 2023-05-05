using Microsoft.EntityFrameworkCore;
namespace Employee.Data
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }
        public DbSet<EmployeeDbContext> Employees { get; set; }
    }
}
//hello