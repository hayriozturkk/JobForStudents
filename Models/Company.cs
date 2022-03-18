namespace JobForStudents
{
    public class Company
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public virtual Category?  Category { get; set; }
        public int AddressId { get; set; }
        public virtual Address? Address { get; set; }
        public virtual ICollection<Employer>? Employer { get; set; }
    }
}