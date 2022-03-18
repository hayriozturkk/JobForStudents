using Microsoft.EntityFrameworkCore;

namespace JobForStudents
{
    public class AccountDatabaseBuilder
    {
        public static void TableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
                {
                    entity.HasKey(e => e.Id);
                    entity.Property(e => e.Email).IsRequired();
                    entity.Property(e => e.Password).IsRequired(); ;
                    entity.Property(e => e.Visibility);
                    entity.HasOne(e => e.Role).WithMany(e => e.Account).HasForeignKey(e => e.RoleId);
                });
                modelBuilder.Entity<Account>().HasData
                (
                    new Account
                    {
                        Id = 1,
                        Email = "hayri.ozturk@sahabt.com",
                        Password = "123456",
                        Visibility = true,
                        RoleId = 1
                    },
                    new Account
                    {
                        Id = 2,
                        Email = "adem.simsek@sahabt.com",
                        Password = "987654",
                        Visibility = false,
                        RoleId = 2
                    }
                    ,
                    new Account
                    {
                        Id = 3,
                        Email = "adem.simsek@sahabt.com",
                        Password = "987654",
                        Visibility = false,
                        RoleId = 2
                    }
                    ,
                    new Account
                    {
                        Id = 4,
                        Email = "adem.simsek@sahabt.com",
                        Password = "987654",
                        Visibility = false,
                        RoleId = 2
                    }
                    ,
                    new Account
                    {
                        Id = 5,
                        Email = "adem.simsek@sahabt.com",
                        Password = "987654",
                        Visibility = false,
                        RoleId = 1
                    }
                );

            }
            static void SetDataToDB(ModelBuilder modelBuilder)
            {
                

            }
        
    }
}