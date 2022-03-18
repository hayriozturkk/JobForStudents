using Microsoft.EntityFrameworkCore;

namespace JobForStudents
{
    public class DistrictDatabaseBuilder
    {

        static void SetDataToDB(ModelBuilder modelBuilder)
        {

        }

        public static void TableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<District>(entity =>
           {
               entity.HasKey(e => e.Id);
               entity.Property(e => e.Name);
               entity.HasOne(c => c.City).WithMany(c => c.District).HasForeignKey(c => c.CityId);
           });
            modelBuilder.Entity<District>().HasData(
               new District
               {
                   Id = 1,
                   Name = "Kecioren",
                   CityId = 1

               },
               new District
               {
                   Id = 2,
                   Name = "Mamak",
                   CityId = 1

               },
               new District
               {
                   Id = 3,
                   Name = "Bagcılar",
                   CityId = 2

               },
               new District
               {
                   Id = 4,
                   Name = "Besiktas",
                   CityId = 2

               },
               new District
               {
                   Id = 5,
                   Name = "Karşıyaka",
                   CityId = 3

               },
               new District
               {
                   Id = 6,
                   Name = "Göztepe",
                   CityId = 3

               },
               new District
               {
                   Id = 7,
                   Name = "Izmit",
                   CityId = 4

               },
               new District
               {
                   Id = 8,
                   Name = "Gölcük",
                   CityId = 4

               },
               new District
               {
                   Id = 9,
                   Name = "Sapanca",
                   CityId = 5

               },
               new District
               {
                   Id = 10,
                   Name = "Serdivan",
                   CityId = 5

               });
        }
    }
}
