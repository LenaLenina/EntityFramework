using System;
using System.Linq;
using DataContext;

namespace _004_Join
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DataModel db = new DataModel())
            {
                //Для объединения таблиц по определенному критерию используется метод Join. Имеет общий критерий - id компании;
                var phones = db.Phones.Join(db.Companies, // второй набор
                    p => p.CompanyId, // свойство-селектор объекта из первого набора
                    c => c.Id, // свойство-селектор объекта из второго набора
                    (p, c) => new // результат
                    {
                        p.Id,
                        p.Name,
                        Company = c.Name,
                        p.Price
                    });
                foreach (var p in phones)
                    Console.WriteLine("{0}.{1} [{2}] - {3}", p.Id, p.Name, p.Company, p.Price);

                Console.WriteLine("---------------------------------------");
                Console.ReadLine();

                //Оператор join
                var phones1 = from p in db.Phones
                             join c in db.Companies on p.CompanyId equals c.Id
                             select new { p.Id, Name = p.Name, Company = c.Name, Price = p.Price };
                foreach (var p in phones1)
                    Console.WriteLine("{0}.{1} [{2}] - {3}", p.Id, p.Name, p.Company, p.Price);
            }
        }
    }
}
