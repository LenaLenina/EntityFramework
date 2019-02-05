namespace _003_StoredProcedures
{
    using System.Collections.Generic;

    public class Company
    {
        public Company()
        {
            Phones = new HashSet<Phone>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Phone> Phones { get; set; }
    }
}
