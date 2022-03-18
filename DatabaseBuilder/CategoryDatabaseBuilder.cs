
using Microsoft.EntityFrameworkCore;

namespace JobForStudents
{
    public class CategoryDatabaseBuilder
    {

         static void SetDataToDB(ModelBuilder modelBuilder)
            {

            }
        public static void TableBuilder(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Category>(entity =>
              {
                  entity.HasKey(e => e.Id);
                   entity.Property(e => e.Name);
                  

              });
              modelBuilder.Entity<Category>().HasData(
               new Category
               {
                   Id = 1,
                   Name = "Elektrik Mühendisliği",

               },
               new Category
               {
                   Id = 2,
                   Name = "Bilgisayar Mühendisliği",

               },
               new Category
               {
                   Id = 3,
                   Name = "Yazılım Mühendisliği",

               },
               new Category
               {
                   Id = 4,
                   Name = "Hizmet Sektörü",

               },
               new Category
               {
                   Id = 5,
                   Name = "Makina Mühendisliği",

               });

        }


    }
}