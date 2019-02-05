using CF.Data;
using CF.DataAccess;
using System;
using System.Linq;

namespace _002_CF_CreateDB
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (var db = new CodeContext())
            {
                Console.WriteLine(db.Database.Connection.ConnectionString);
                Console.WriteLine();

                db.Attendees.Add(new Attendee { FirstName = "Andrei", LastName = "Sokolov", DateAdded = DateTime.Now});
                db.SaveChanges();

                var attendees = db.Attendees.ToList();
                Console.WriteLine("Count - {0}",attendees.Count());
                foreach (var item in attendees)
                {
                    Console.WriteLine("{0}. {1} {2} <{3}>", item.AttendeKey, item.FirstName, item.FirstName, item.DateAdded);
                }            
            }
            Console.ReadKey();
        }
    }
}
