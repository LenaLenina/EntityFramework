namespace _003_StoredProcedures
{
    public class Phone
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }
    }
}
