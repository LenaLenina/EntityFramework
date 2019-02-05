using System;
using System.Linq;
using DataContext;

namespace _005_Grouping
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DataModel db = new DataModel())
            {
                //Чтобы сгруппировать данные по определенным параметрам используются оператор group by или метод GroupBy().
                var groups = from p in db.Phones
                             group p by p.Company.Name;
                foreach (var g in groups)
                {
                    Console.WriteLine(g.Key);
                    foreach (var p in g)
                        Console.WriteLine("{0} - {1}", p.Name, p.Price);
                    Console.WriteLine();
                }

                Console.WriteLine("---------------------------------------");
                Console.ReadLine();

                //Кроме свойства Key у группы есть свойство Count
                var groups1 = db.Phones.GroupBy(p => p.Company.Name);
                foreach (var g in groups1)
                {
                    Console.WriteLine("{0} - {1}",g.Key, g.Count());
                    foreach (var p in g)
                        Console.WriteLine("{0} - {1}", p.Name, p.Price);
                    Console.WriteLine();
                }
            }
        }
    }
}
