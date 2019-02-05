using System;
using System.Data.Entity;
using System.Linq;

namespace InitializationDB_1
{
    class Program
    {
        static void Main(string[] args)
        {
           //Database.SetInitializer(new CreateDatabaseIfNotExists<CodeContext>());
           //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CodeContext>());
           //Database.SetInitializer(new DropCreateDatabaseAlways<CodeContext>());

            using (CodeContext db = new CodeContext())
            {
                db.Phones.Add(new Phone { Name = "Nokia Lumia 530", Price = 2000});
                db.Phones.Add(new Phone { Name = "Nokia Lumia 630", Price = 3000 });
                db.Phones.Add(new Phone { Name = "Nokia Lumia 730", Price = 4000 });
                db.Phones.Add(new Phone { Name = "Nokia Lumia 830", Price = 6000 });
                db.Phones.Add(new Phone { Name = "Nokia Lumia 930", Price = 9000 });

                db.SaveChanges();

                var phones = db.Phones.ToList();

                foreach (var phone in phones)
                {
                    Console.WriteLine("{0}.{1} - {2}",phone.Id, phone.Name, phone.Price);
                }

            }
        }
    }
}
