using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace AsynchronyEF
{
    public static class Infrastructure
    {
        public static async Task GetObjectsAsync()
        {
            using (ModelDB db = new ModelDB())
            {
                await db.Phones.ForEachAsync(p =>
                {
                    Console.WriteLine("{0}.{1} - {2})", p.Id, p.Name, p.Price);
                });
            }
        }

        public static async Task SaveObjectsAsync(Phone p)
        {
            using (ModelDB db = new ModelDB())
            {
                db.Phones.Add(p);
                await db.SaveChangesAsync();
            }
        }
    }
}
