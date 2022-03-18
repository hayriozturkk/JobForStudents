namespace JobForStudents
{
    public class Account
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Visibility { get; set; }
        public int RoleId { get; set; }
        public virtual Role? Role { get; set; }
        public bool IsBlocked { get; set; }
        public virtual ICollection<Student> Student { get; set; }
        public virtual ICollection<Employer> Employer { get; set; }

    }


}