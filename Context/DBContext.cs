using Microsoft.EntityFrameworkCore;

namespace JobForStudents
{
    public class DBContext : DbContext
    {
        public DbSet<Account>? Accounts { get; set; }
        public DbSet<Address>? Addresses { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<City>? Cities { get; set; }
        public DbSet<Company>? Companies { get; set; }
        public DbSet<District>? Districts { get; set; }
        public DbSet<Employer>? Employers { get; set; }
        public DbSet<JobAdvertisement>? JobAdvertisements { get; set; }
        public DbSet<Role>? Roles { get; set; }
        public DbSet<Student>? Students { get; set; }
        public DbSet<School>? Schools { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));
            optionsBuilder.UseMySql("server=localhost;database=sahabt;user=root;port=3306;password=toortoor", serverVersion);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            AccountDatabaseBuilder.TableBuilder(modelBuilder);
            AddressDatabaseBuilder.TableBuilder(modelBuilder);
            CategoryDatabaseBuilder.TableBuilder(modelBuilder);
            CityDatabaseBuilder.TableBuilder(modelBuilder);
            CompanyDatabaseBuilder.TableBuilder(modelBuilder);
            DistrictDatabaseBuilder.TableBuilder(modelBuilder);
            EmployerDatabaseBuilder.TableBuilder(modelBuilder);
            JobAdvertisementDatabaseBuilder.TableBuilder(modelBuilder);
            RoleDatabaseBuilder.TableBuilder(modelBuilder);
            StudentDatabaseBuilder.TableBuilder(modelBuilder);
            SchoolDatabaseBuilder.TableBuilder(modelBuilder);

        }
    }
}