using Microsoft.EntityFrameworkCore;

namespace DDDStudy.Infra.Data.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        //TODO
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        //TODO
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
