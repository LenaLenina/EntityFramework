using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CF.Data
{
    [Table("Att")]
    public class Attendee
    {
        [Key]
        public int AttendeKey { get; set; }

        [Required, MinLength(3), MaxLength(20)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
