namespace JobForStudents
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Account>? Account { get; set; }
        


    }
}