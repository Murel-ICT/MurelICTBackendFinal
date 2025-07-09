using Microsoft.EntityFrameworkCore;
using MurelICTBackend.Models;

namespace MurelICTBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ContactForm> ContactForms { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}

