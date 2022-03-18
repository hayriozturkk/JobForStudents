namespace JobForStudents
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public long PhoneNumber { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public Education Education { get; set; }
        public EducationTour EducationTour { get; set; }
        public int AddressId { get; set; }
        public virtual Address? Address { get; set; }
        public int SchoolId { get; set; }
        public virtual School? School { get; set; }
        public int AccountId { get; set; }
        public virtual Account? Account { get; set; }
        

    }
}