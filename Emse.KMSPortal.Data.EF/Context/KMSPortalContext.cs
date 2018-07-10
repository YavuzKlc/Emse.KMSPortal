using Emse.KMSPortal.Data.Model;
using System.Data.Entity;
namespace Emse.KMSPortal.Data.EF.Context
{
    public partial class KMSPortalContext : DbContext
    {
        public KMSPortalContext()
            : base("name=KMSPortalContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Kiosk> Kiosks { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<UserActivitiyLog> UserActivitiyLogs { get; set; }
    }
}
