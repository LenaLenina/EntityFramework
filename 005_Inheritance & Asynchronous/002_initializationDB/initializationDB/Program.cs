using System;

namespace initializationDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new InitializationModel())
            {
                db.Phones.Add(new Phone {Name = "HTC", Price = 2500});
                db.SaveChanges();

                foreach (var item in db.Phones)
                {
                    Console.WriteLine("{0}.{1} - {2}",item.Id, item.Name, item.Price);
                }
            }
        }
    }
}
