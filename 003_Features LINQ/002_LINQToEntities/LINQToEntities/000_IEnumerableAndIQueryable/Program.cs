using System;
using System.Collections.Generic;
using System.Linq;
using DataContext;

namespace _000_IEnumerableAndIQueryable
{
    class Program
    {
        //Методы расширений LINQ могут возвращать два объекта: IEnumerable и IQueryable.
        //Интерфейс IEnumerable находится в пространстве имен System.Collections. 
        //Интерфейс IQueryable располагается в пространстве имен System.Linq.
        static void Main(string[] args)
        {
            using (DataModel db = new DataModel())
            {
                IEnumerable<Phone> phone = db.Phones.ToList();
                Console.ReadKey();
                phone = phone.Where(p => p.Id > 3);
                Console.ReadKey();

                Console.WriteLine(phone);
                Console.ReadKey();

                foreach (var item in phone)
                {
                    Console.WriteLine("{0}.{1}", item.Id, item.Name);
                }

                Console.WriteLine("---------------------------------");
                Console.ReadKey();

                IQueryable<Phone> phone1 = db.Phones;
                Console.ReadKey();

                phone1 = phone1.Where(p => p.Id > 3);
                Console.ReadKey();

                Console.WriteLine(phone1);
                Console.ReadKey();

                foreach (var item in phone1)
                {
                    Console.WriteLine("{0}.{1}", item.Id, item.Name);
                }
                
            }
        }
    }
}
