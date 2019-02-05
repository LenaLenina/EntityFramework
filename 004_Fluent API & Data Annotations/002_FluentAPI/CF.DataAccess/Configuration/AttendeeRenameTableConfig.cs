using CF.Data;
using System.Data.Entity.ModelConfiguration;

namespace CF.DataAccess
{
    public class AttendeeRenameTableConfig : EntityTypeConfiguration<Attendee>
    {
        public AttendeeRenameTableConfig()
        {
            ToTable("Attendees");
            HasKey(p => p.AttendeeTrackingID); ;
            Property(p => p.LastName).IsRequired().HasMaxLength(100);
            Property(p => p.DateAdded).IsRequired().HasColumnName("Data");
        }
    }
}
