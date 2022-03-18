using Microsoft.EntityFrameworkCore;

namespace JobForStudents
{
    public class AddressDatabaseBuilder
    {

        static void SetDataToDB(ModelBuilder modelBuilder)
        {


        }
        public static void TableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
              {
                  entity.HasKey(e => e.Id);
                  entity.Property(e => e.OpenAddress).IsRequired();
                  entity.Property(e => e.CityId).IsRequired();
                  entity.Property(e => e.DistrictId).IsRequired();
                  
              });
              modelBuilder.Entity<Address>().HasData(
               new Address
               {
                   Id = 1,
                   CityId =1,
                   DistrictId =1,
                   OpenAddress = "asdasdads"

               },
               new Address
               {
                   Id = 2,
                   CityId =1,
                   DistrictId =2,
                   OpenAddress = "asdasdasdasdasdad"

               },
               new Address
               {
                   Id = 3,
                   CityId =2,
                   DistrictId =3,
                   OpenAddress = "asdasdadASDASD"

               },
               new Address
               {
                   Id = 4,
                   CityId =2,
                   DistrictId =4,
                   OpenAddress = "ASDASDasdasdad"

               },
               new Address
               {
                   Id = 5,
                   CityId =3,
                   DistrictId =5,
                   OpenAddress = "asdasdadASDASD"

               },
               new Address
               {
                   Id = 6,
                   CityId =3,
                   DistrictId =6,
                   OpenAddress = "asASDSADdasdad"

               });






        }


    }
}