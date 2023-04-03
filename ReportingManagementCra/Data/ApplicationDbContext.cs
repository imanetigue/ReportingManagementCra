using Microsoft.EntityFrameworkCore;
using ReportingManagementCra.Models;

namespace ReportingManagementCra.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }



    }
}
