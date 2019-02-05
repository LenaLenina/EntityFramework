using System;
using System.Data.Entity;
using System.Linq;
using AWModel;

namespace _002__StrictLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AWDATAEntities db = new AWDATAEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;

                db.Customers.Load();

                var query = from order in db.SalesOrderHeaders
                            select order;

                Console.WriteLine(query);
                Console.ReadKey();

                var ordersList = query.ToList();
                Console.ReadKey();

                foreach (var order in ordersList)
                {
                    //Нет запросов к БД!!!
                    if (order.Customer != null)
                    {
                        Console.ReadKey();
                        Console.WriteLine(order.Customer.LastName);
                    }
                }
            }
        }
    }
}
