using System;
using System.Data.Entity;

namespace TPH
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<TPHModel>());

            using (TPHModel db = new TPHModel())
            {
                db.Phones.Add(new Phone { Name = "Samsung Galaxy S3", Company = "Samsung", Price = 5000 });
                db.Phones.Add(new Phone { Name = "Nokia Lumia 730", Company = "Nokia", Price = 3000 });

                var s1 = new Smartphone { Name = "iPhone 6", Company = "Apple", Price = 16000, OS = "iOS" };
                db.Smartphones.Add(s1);

                db.Smartphones.Add(new Smartphone {Name = "iPhone 5", Company = "Apple", Price = 10000, OS = "iOS"});

                db.SaveChanges();

                foreach (Phone p in db.Phones)
                    Console.WriteLine("{0} ({1}) - {2}", p.Name, p.Company, p.Price);
                Console.WriteLine();
                foreach (Smartphone p in db.Smartphones)
                    Console.WriteLine("{0} ({1}, {2}) - {3}", p.Name, p.Company, p.Price, p.OS);

            }
        }
    }
}
