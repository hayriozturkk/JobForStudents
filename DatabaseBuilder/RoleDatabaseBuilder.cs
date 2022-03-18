using Microsoft.EntityFrameworkCore;

namespace JobForStudents
{
    public class RoleDatabaseBuilder
    {

        static void SetDataToDB(ModelBuilder modelBuilder)
        {

        }

        public static void TableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>(entity =>
           {
               entity.HasKey(e => e.Id);
               entity.Property(e => e.Name);
           });
            modelBuilder.Entity<Role>().HasData(
               new Role
               {
                   Id = 1,
                   Name = "Admin",

               },
               new Role
               {
                   Id = 2,
                   Name = "Employer",

               },
               new Role
               {
                   Id = 5,
                   Name = "Student",

               });
        }
    }
}
