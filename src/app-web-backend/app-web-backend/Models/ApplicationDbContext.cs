using Microsoft.EntityFrameworkCore;

namespace app_web_backend.Models
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Login> Logins { get; set; }
        //public DbSet<Gosto> Gostos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
