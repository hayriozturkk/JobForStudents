using Microsoft.EntityFrameworkCore;

namespace JobForStudents
{
    public class JobAdvertisementDatabaseBuilder
    {

        static void SetDataToDB(ModelBuilder modelBuilder)
        {

        }

        public static void TableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobAdvertisement>(entity =>
           {
               entity.HasKey(e => e.Id);
               entity.Property(e => e.Name);
               entity.Property(e => e.Title);
               entity.Property(e => e.Description);
               entity.Property(e => e.Salary);
               entity.Property(e => e.WorkingTime);
               entity.Property(e => e.NumberOfPeopleHiring);
               entity.Property(e => e.CategoryId);
               entity.HasOne(e => e.Employer).WithMany(e => e.JobAdvertisement).HasForeignKey(e => e.EmployerId);
           });
            modelBuilder.Entity<JobAdvertisement>().HasData(
               new JobAdvertisement
               {
                   Id = 1,
                   Name = ".Net Core Developer",
                   Title="Yazılım Mühendisi",
                   Description=".net core bilen yazılım müh arayıyrouz",
                   Salary=10000,
                   CategoryId =2,
                   EmployerId=1

               },
               new JobAdvertisement
               {
                    Id = 2,
                   Name = ".Net Developer",
                   Title="Yazılım Mühendisi",
                   Description=".net core bilen yazılım müh arayıyrouz",
                   Salary=8000,
                   CategoryId =2,
                   EmployerId=2

               },
               new JobAdvertisement
               {
                    Id = 3,
                   Name = "java Developer",
                   Title="Yazılım Mühendisi",
                   Description=".net core bilen yazılım müh arayıyrouz",
                   Salary=15000,
                   CategoryId =1,
                   EmployerId=3


               },
               new JobAdvertisement
               {
                    Id = 4,
                   Name = "react Developer",
                   Title="Yazılım Mühendisi",
                   Description=".net core bilen yazılım müh arayıyrouz",
                   Salary=12000,
                   CategoryId =2,
                   EmployerId=1


               });
        }
    }
}
