using Microsoft.EntityFrameworkCore;

namespace JobForStudents
{
    public class EmployerDatabaseBuilder
    {
        public static void TableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employer>(entity =>
              {
                  entity.HasKey(e => e.Id);
                  entity.Property(e => e.Name).IsRequired();
                  entity.Property(e => e.Surname).IsRequired();
                  entity.Property(e => e.Gender);
                  entity.Property(e => e.PhoneNumber).IsRequired();
                  entity.Property(e => e.BirthDate).IsRequired();
                  entity.Property(e => e.CompanyId);
                  entity.Property(e => e.AccountId);
              });
              modelBuilder.Entity<Employer>().HasData
            (
                new Employer
                {
                    Id = 1,
                    Name = "Employer1",
                    Surname = "Emp1",
                    Gender = (Gender)1,
                    PhoneNumber = 05311234567,
                    BirthDate = Convert.ToDateTime("30.12.2020"),
                    CompanyId = 1,
                    AccountId = 1
                },
                new Employer
                {
                    Id = 2,
                    Name = "Employer2",
                    Surname = "Emp2",
                    Gender = (Gender)1,
                    PhoneNumber = 05311234567,
                    BirthDate = Convert.ToDateTime("30.12.2021"),
                    CompanyId = 2,
                    AccountId = 2
                },
                new Employer
                {
                    Id = 3,
                    Name = "Employer3",
                    Surname = "Emp3",
                    Gender = (Gender)2,
                    PhoneNumber = 05311234567,
                    BirthDate = Convert.ToDateTime("30.12.2022"),
                    CompanyId = 3,
                    AccountId = 3
                },
               new Employer
               {
                   Id = 4,
                   Name = "Employer4",
                   Surname = "Emp4",
                   Gender = (Gender)2,
                   PhoneNumber = 05311234567,
                   BirthDate = Convert.ToDateTime("30.12.2023"),
                   CompanyId = 4,
                   AccountId = 4
               }
            );

        }
        static void SetDataToDB(ModelBuilder modelBuilder)
        {

            
        }

    }
}