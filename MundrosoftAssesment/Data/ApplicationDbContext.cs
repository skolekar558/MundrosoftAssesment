using Microsoft.EntityFrameworkCore;
using MundrosoftAssesment.Models;

namespace MundrosoftAssesment.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Departments> Departments {  get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Employees> Employees { get; set; }
       
    }
}
