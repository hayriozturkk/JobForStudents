using Microsoft.EntityFrameworkCore;

namespace JobForStudents
{
    public class CompanyDatabaseBuilder
    {

        static void SetDataToDB(ModelBuilder modelBuilder)
        {


        }
        public static void TableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>(entity =>
              {
                  entity.HasKey(e => e.Id);
                  entity.Property(e => e.Name);
                  entity.Property(e => e.CategoryId);
                  entity.Property(e => e.AddressId);

              });
              modelBuilder.Entity<Company>().HasData(
               new Company
               {
                   Id = 1,
                   Name = "Öztürk Mühendislik",
                   CategoryId =1,
                   AddressId =1

               },
               new Company
               {
                   Id = 2,
                   Name = "SahaBt Yazilim",
                   CategoryId =3,
                   AddressId =2

               },
               new Company
               {
                   Id = 3,
                   Name = "Öztürk Kafe Çay Bahçesi",
                   CategoryId =4,
                   AddressId =3

               },
               new Company
               {
                   Id = 4,
                   Name = "Öztürk Kafe Çay Bahçesi",
                   CategoryId =4,
                   AddressId =3

               });

        }


    }
}