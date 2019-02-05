using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPC
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TPCModel : DbContext
    {
        public TPCModel()
            : base("name=TPCModel")
        {
        }


        public virtual DbSet<Phone> Phones { get; set; }
        public virtual DbSet<Smartphone> Smartphones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Phone>()
            .Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Phones");
            });
            modelBuilder.Entity<Smartphone>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Smartphone");
            });
        }
    }
    public class Phone
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }
    }

    public class Smartphone : Phone
    {
        public string OS { get; set; }
    }

}