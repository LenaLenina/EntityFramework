using System;
using System.Linq;
using AWModel;

namespace _003_EagerLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AWDATAEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;

                var query = from order in db.SalesOrderHeaders.Include("Customer")
                            select order;

                Console.WriteLine(query);
                Console.ReadKey();

                var ordersList = query.ToList();
                Console.ReadKey();

                foreach (var order in ordersList)
                {
                    //Нет запросов к БД!!!
                    Console.ReadKey();
                    Console.WriteLine(order.Customer.LastName);
                }
            }
        }
    }
}
