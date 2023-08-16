using DemoDotNetMVC.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace DemoDotNetMVC.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employess {  get; set; }
    }
}
