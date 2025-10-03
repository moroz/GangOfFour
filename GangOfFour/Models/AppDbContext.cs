using System.Data.Entity;
using Npgsql;

namespace GangOfFour.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("public");
        }
    }

    public class NpgSqlConfiguration : DbConfiguration
    {
        public NpgSqlConfiguration()
        {
            var name = "Npgsql";

            SetProviderFactory(providerInvariantName: name, providerFactory: NpgsqlFactory.Instance);
            SetProviderServices(providerInvariantName: name, provider: NpgsqlServices.Instance);
            SetDefaultConnectionFactory(connectionFactory: new NpgsqlConnectionFactory());
        }
    }
}