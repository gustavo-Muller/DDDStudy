using DDDStudy.Domain.Entities;
using DDDStudy.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace DDDStudy.Infra.Data.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext() { }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Example> example { get; set; }

        public override int SaveChanges()
        {
            try
            {
                var entries = ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null);
                foreach (var entry in entries)
                {
                    var dataCadastroProperty = entry.Property("DataCadastro"); ;

                    switch (entry.State)
                    {
                        case EntityState.Added:
                            dataCadastroProperty.CurrentValue = DateTime.Now;
                            break;
                        case EntityState.Modified:
                            dataCadastroProperty.IsModified = false;
                            break;
                    }
                }

            }
            catch (Exception)
            {
                //TODO
                throw;
            }

            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ExampleMapping());
        }
    }
}
