namespace InitializationDB_1
{
    using System.Data.Entity;

    public class CodeContext : DbContext
    {
        //static CodeContext()
        //{
        //    Database.SetInitializer(new CreateDatabaseIfNotExists<CodeContext>());
        //}

        public CodeContext()
            : base("name=CodeContext")
        {
        }
         public virtual DbSet<Phone> Phones { get; set; }
    }

}