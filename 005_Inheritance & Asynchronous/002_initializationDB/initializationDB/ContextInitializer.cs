using System.Data.Entity;

namespace initializationDB
{
    class ContextInitializer: DropCreateDatabaseAlways<InitializationModel>
    {
        protected override void Seed(InitializationModel context)
        {
            Phone phone1 = new Phone { Name = "Nokia Lumia 930", Price = 10000 };
            Phone phone2 = new Phone { Name = "Nokia Lumia 630", Price = 3000 };

            context.Phones.Add(phone1);
            context.Phones.Add(phone2);
            context.SaveChanges();
        }
    }
}
