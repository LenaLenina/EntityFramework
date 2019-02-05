using System.Data.Entity;
using CF.Data;

namespace CF.DataAccess
{
    public class CodeContext : DbContext
    {
        static CodeContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CodeContext>());
        }

        public CodeContext(): base("dbContext")
        {           
        }

        public DbSet<Attendee> Attendees { get; set; }
    }
}
