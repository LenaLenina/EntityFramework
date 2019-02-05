namespace _001_WorkInSql
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModelSql")
        {
        }

        public virtual DbSet<Companies> Companies { get; set; }
        public virtual DbSet<Phones> Phones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Companies>()
                .HasMany(e => e.Phones)
                .WithRequired(e => e.Companies)
                .HasForeignKey(e => e.CompanyId);
        }
    }
}
