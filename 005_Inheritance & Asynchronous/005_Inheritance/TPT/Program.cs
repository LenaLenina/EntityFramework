using System;
using System.Data.Entity;

namespace TPT
{
    class Program
    {
        static void Main(string[] args)
        {
           // Database.SetInitializer( new DropCreateDatabaseAlways<TPTModel>());

            using (var db = new TPTModel())
            {
                db.Phones.Add(new Phone { Name = "Samsung Galaxy S3", Company = "Samsung", Price = 6000 });
                db.Phones.Add(new Phone { Name = "Nokia Lumia 930", Company = "Nokia", Price = 9000 });

                var s1 = new Smartphone { Name = "iPhone 6", Company = "Apple", Price = 18000, OS = "iOS" };
                db.Smartphones.Add(s1);
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
