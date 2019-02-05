namespace initializationDB
{
    using System.Data.Entity;

    public class InitializationModel : DbContext
    {
        static InitializationModel()
        {
            Database.SetInitializer(new ContextInitializer());
        }

        public InitializationModel()
            : base("name=InitializationModel")
        {
        }
        public virtual DbSet<Phone> Phones { get; set; }
    }

}