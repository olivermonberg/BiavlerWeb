using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BiavlerWeb.Areas.Identity.Data
{
    public class BiavlerWebContext : IdentityDbContext<BiavlerWebUser>
    {
        public BiavlerWebContext(DbContextOptions<BiavlerWebContext> options)
            : base(options)
        {
        }

        public DbSet<BiavlerWeb.Models.Varroataelling> Varroataellinger { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
