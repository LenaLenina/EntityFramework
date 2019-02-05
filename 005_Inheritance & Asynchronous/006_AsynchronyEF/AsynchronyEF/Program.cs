using System.Threading.Tasks;

namespace AsynchronyEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone
            {
                Name = "Nokia Lumia 930",
                Price = 9000
            };

            Task task = Infrastructure.SaveObjectsAsync(phone);
            task.Wait();

            task = Infrastructure.GetObjectsAsync();
            task.Wait();

        }
    }
}
