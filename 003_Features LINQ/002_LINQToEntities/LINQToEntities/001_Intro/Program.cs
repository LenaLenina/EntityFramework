using System;
using System.Linq;
using DataContext;

namespace _001_Intro
{
    //Для создания запросов в Linq to Entities, так же, как и в Linq to Objects, 
    //мы можем применять операторы LINQ и методы расширения LINQ.

    //Здесь используются два метода Where. В первом случае, 
    //db.Phones.Where(p => p.Price <= 10000) транслируется в выражение SQL. 
    //Далее метод ToList() по результатам запроса создает список в памяти компьютера. 
    //Посде этого мы уже имеем дело со списком в памяти, а не с базой данных. И далее вызов Where(p => p.CompanyId > 1) 
    //будет обращаться к списку в памяти и будет представлять Linq to Object.
    class Program
    {
        private static DataModel db;
        public static void Output(IQueryable<Phone> queryable)
        {
            foreach (var item in queryable)
            {
                Console.WriteLine("{0}.{1} = {2}", item.Id, item.Name, item.Price);
            }
        }

        static void Main(string[] args)
        {
            using (db = new DataModel())
            {
                //Операторы LINQ
                var phones = from p in db.Phones
                             where p.Price <= 10000
                             select p;

                Console.WriteLine("Query:\n {0}", phones);
                Console.WriteLine();

                Output(phones);
                Console.WriteLine("--------------------------------");
                Console.ReadKey();
                //Запрос с помощью методов расширений LINQ (Linq to Entities)
                var phones1 = db.Phones.Where(p => p.Price <= 10000);

                Console.WriteLine("Query:\n {0}", phones1);
                Console.WriteLine();

                Output(phones1);
                Console.WriteLine("--------------------------------");
                Console.ReadKey();

                // Linq to Objects
                //var phones2 = db.Phones.Where(p => p.Price <= 10000).ToList().Where(p => p.CompanyId > 1); //не отложенный запрос выборка на стороне клиента
                var phones2 = db.Phones.Where(p => p.Price <= 10000).Where(p => p.CompanyId > 1); //отложенный запрос выборка на стороне сервера

                //var phones2 = db.Phones.Where(p => p.Price <= 10000).ToList();//не отложенный запрос выборка на стороне клиента
                //var phones3 = phones2.Where(p => p.CompanyId > 1);

                Console.WriteLine("Query:\n {0}", phones2);
                Console.WriteLine();
                Console.ReadKey();

                foreach (var item in phones2)
                {
                    Console.WriteLine("{0}.{1} = {2}", item.Id, item.Name, item.Price);
                }
                Console.WriteLine("--------------------------------");


            }
        }
    }
}
