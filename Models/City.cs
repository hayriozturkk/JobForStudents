namespace JobForStudents
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<District>? District { get; set; }
    }


}