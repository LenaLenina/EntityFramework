using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Model_First
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Model1Container db = new Model1Container())
            {
                db.Users.Add( new User {Name = "Tom", Age = 10});
                db.Users.Add(new User {Name = "John", Age = 25});
                db.SaveChanges();

                var users = db.Users;

                foreach (var item in users)
                {
                    Console.WriteLine("{0}.{1} - {2}",item.Id, item.Name, item.Age);
                }
            }

            Console.Read();
        }
    }
}
