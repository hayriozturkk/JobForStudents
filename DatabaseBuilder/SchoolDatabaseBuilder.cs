using Microsoft.EntityFrameworkCore;

namespace JobForStudents
{
    public class SchoolDatabaseBuilder
    {

        static void SetDataToDB(ModelBuilder modelBuilder)
        {


        }
        public static void TableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<School>(entity =>
              {
                  entity.HasKey(e => e.Id);
                  entity.Property(e => e.Name).IsRequired();
                  entity.Property(e => e.AddressId);
                  
              });
              modelBuilder.Entity<School>().HasData(
               new School
               {
                   Id = 1,
                   Name = "Zonguldak Bülent Ecevit Üniversitesi",
                   AddressId=1

               },
               new School
               {
                   Id = 2,
                   Name = "Karaelmas Üniversitesi",
                   AddressId=2

               },
               new School
               {
                   Id = 3,
                   Name = "Türk Kızılası Kartal Anadolu Lisesi",
                   AddressId=3

               });

        }


    }
}