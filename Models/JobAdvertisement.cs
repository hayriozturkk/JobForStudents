namespace JobForStudents
{
    public class JobAdvertisement
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Salary { get; set; }
        public WorkingTime WorkingTime { get; set; }
        public int NumberOfPeopleHiring { get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        public int EmployerId { get; set; }
        public virtual Employer? Employer { get; set; }
        ///public Address Address { get; set; }

    }
}