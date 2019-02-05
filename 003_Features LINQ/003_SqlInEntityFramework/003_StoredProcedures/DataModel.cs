namespace _003_StoredProcedures
{
    using System.Data.Entity;

    public  class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModelSql")
        {
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }
    }
}
