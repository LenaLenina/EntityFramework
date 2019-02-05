using System;
using System.Linq;
using AWModel;

namespace _001_LazyLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AWDATAEntities())
            {
                //Code-First defaults: true, DB/ModelFirst - See EDMX Props
                db.Configuration.LazyLoadingEnabled = false; 

                var query = from order in db.SalesOrderHeaders
                            select order;

                Console.WriteLine(query);
                Console.ReadKey();

                var ordersList = query.ToList();
                Console.ReadKey();

                foreach (var order in ordersList)
                {
                    // На каждой итерации обращение к БД!
                    if (order.Customer != null)
                    {
                        Console.ReadKey();
                        Console.WriteLine("{0}.{1}", order.Customer.CustomerID, order.Customer.LastName);
                    }
                }
            }
        }
    }
}
