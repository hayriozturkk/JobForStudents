using Microsoft.EntityFrameworkCore;

namespace JobForStudents
{
    public class StudentDatabaseBuilder
    {
        public static void TableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
              {
                  entity.HasKey(e => e.Id);
                  entity.Property(e => e.Name).IsRequired();
                  entity.Property(e => e.Surname).IsRequired();
                  entity.Property(e => e.Gender);
                  entity.Property(e => e.PhoneNumber).IsRequired();
                  entity.Property(e => e.BirthDate).IsRequired();
                  entity.Property(e => e.Education);
                  entity.Property(e => e.EducationTour);
                  entity.Property(e => e.AddressId);
                  entity.Property(e => e.SchoolId);
                  entity.Property(e => e.AccountId);
              });
               modelBuilder.Entity<Student>().HasData(
                    new Student
                    {
                        Id = 1,
                        Name = "Hayri",
                        Surname = "Öztürk",
                        Gender = (Gender)1 ,
                        PhoneNumber=05311234567,
                        BirthDate=Convert.ToDateTime("30.12.2020"),
                        Education=(Education)1,
                        EducationTour=(EducationTour)1,
                        AddressId=1,
                        SchoolId=1,
                        AccountId=1
                    },
                    new Student
                    {
                        Id = 2,
                        Name = "Hayri222",
                        Surname = "Öztürk222",
                        Gender = (Gender)1 ,
                        PhoneNumber=11111111111,
                        BirthDate=Convert.ToDateTime("30.12.2021"),
                        Education=(Education)2,
                        EducationTour=(EducationTour)2,
                        AddressId=2,
                        SchoolId=2,
                        AccountId=2
                    },
                    new Student
                    {
                        Id = 3,
                        Name = "Hayri333",
                        Surname = "Öztürk333",
                        Gender = (Gender)2 ,
                        PhoneNumber=2222222222,
                        BirthDate=Convert.ToDateTime("30.12.2022"),
                        Education=(Education)3,
                        EducationTour=(EducationTour)1,
                        AddressId=3,
                        SchoolId=3,
                        AccountId=3
                    },
                    new Student
                    {
                        Id = 4,
                        Name = "Hayri4444",
                        Surname = "Öztürk444",
                        Gender = (Gender)2 ,
                        PhoneNumber=44444444444,
                        BirthDate=Convert.ToDateTime("30.12.2023"),
                        Education=(Education)4,
                        EducationTour=(EducationTour)1,
                        AddressId=4,
                        SchoolId=3,
                        AccountId=4
                    }
                );
            }
            static void SetDataToDB(ModelBuilder modelBuilder)
            {

               
            }
        
    }
}