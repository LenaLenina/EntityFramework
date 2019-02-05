using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPC
{
    class Program
    {
        static void Main(string[] args)
        {
           // Database.SetInitializer( new DropCreateDatabaseAlways<TPCModel>());

            using (var db = new TPCModel())
            {
                db.Phones.Add(new Phone { Name = "Samsung Galaxy S4", Company = "Samsung", Price = 4000 });
                db.Phones.Add(new Phone { Name = "Nokia Lumia 530", Company = "Nokia", Price = 2000 });

                var s1 = new Smartphone { Name = "iPhone 4", Company = "Apple", Price = 6000, OS = "iOS" };
                db.Smartphones.Add(s1);
                db.SaveChanges();

                foreach (var p in db.Phones)
                    Console.WriteLine("{0} ({1}) - {2}", p.Name, p.Company, p.Price);
                Console.WriteLine();
                foreach (var p in db.Smartphones)
                    Console.WriteLine("{0} ({1}, {2}) - {3}", p.Name, p.Company, p.Price, p.OS);
            }
        }
    }
}
