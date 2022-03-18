namespace JobForStudents{
    public class District{

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual  City? City { get; set; }
        public int CityId { get; set; }

    }

    
}