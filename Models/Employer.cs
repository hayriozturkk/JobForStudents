namespace JobForStudents
{
    public class Employer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Gender Gender { get; set; }
        public long PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public int CompanyId { get; set; }
        public virtual Company? Company { get; set; }
        public int AccountId { get; set; }
        public virtual  Account? Account { get; set; }
        public virtual ICollection<JobAdvertisement>? JobAdvertisement { get; set; }

    }
}