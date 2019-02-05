using System;
using System.Linq;
using DataContext;

namespace _007_SetOperations
{
    class Program
    {
        //Чтобы найти пересечение выборок, (элементы, которые присутствуют сразу в двух выборках), 
        //используется метод Intersect():
        static void Main(string[] args)
        {
            using (DataModel db = new DataModel())
            {
                var phones = db.Phones.Where(p => p.Price < 25000)
                                      .Intersect(db.Phones.Where(p => p.Name.Contains("Samsung")));

                foreach (var item in phones)
                    Console.WriteLine("{0}.{1}",item.Id, item.Name);
            }
        }
    }
}
