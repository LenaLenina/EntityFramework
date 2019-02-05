namespace AsynchronyEF
{
    using System.Data.Entity;

    public class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<Phone> Phones { get; set; }
    }

}