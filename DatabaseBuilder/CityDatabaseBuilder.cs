using Microsoft.EntityFrameworkCore;

namespace JobForStudents
{
    public class CityDatabaseBuilder
    {

        static void SetDataToDB(ModelBuilder modelBuilder)
        {

        }

        public static void TableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
           {
               entity.HasKey(e => e.Id);
               entity.Property(e => e.Name);
           });
            modelBuilder.Entity<City>().HasData(
               new City
               {
                   Id = 1,
                   Name = "Ankara",

               },
               new City
               {
                   Id = 2,
                   Name = "İstanbul",

               },
               new City
               {
                   Id = 3,
                   Name = "İzmir",

               },
               new City
               {
                   Id = 4,
                   Name = "Kocaeli",

               },
               new City
               {
                   Id = 5,
                   Name = "Sakarya",

               });
        }
    }
}
