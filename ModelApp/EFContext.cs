using Microsoft.EntityFrameworkCore;

namespace ModelApp
{
    public class EFContext : DbContext
    {
        public EFContext() { }


        public EFContext(DbContextOptions<EFContext> options)
            : base(options) { }

        private const string connectiostring = "Server=***;Database=ForSignalR;Trusted_Connection=True;TrustServerCertificate=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectiostring);
        }

        public DbSet<Discussion> Discussions { get; set; }
    }
}
