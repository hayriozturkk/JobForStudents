using Microsoft.EntityFrameworkCore;

namespace JobForStudents
{
    public class JobAdvertisementRepository : IJobAdvertisementRepository
    {
        DBContext _DbContext;

        public JobAdvertisementRepository()
        {
            _DbContext = new DBContext();
        }

        public async Task<JobAdvertisement> CreateJobAdvertisement(JobAdvertisement JobAdvertisement)
        {
            await _DbContext.Set<JobAdvertisement>().AddAsync(JobAdvertisement);
            await _DbContext.SaveChangesAsync();
            return JobAdvertisement;
        }

        public async Task<JobAdvertisement> DeleteJobAdvertisement(int id)
        {
            var deletedJobAdvertisement = await _DbContext.Set<JobAdvertisement>().FirstOrDefaultAsync(x => x.Id == id);
            _DbContext.Set<JobAdvertisement>().Remove(deletedJobAdvertisement);
            _DbContext.SaveChangesAsync();
            return deletedJobAdvertisement;

        }

        public async Task<JobAdvertisement> FindJobAdvertisementById(int id)
        {
            return await _DbContext.Set<JobAdvertisement>().FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<JobAdvertisement>> GetAllJobAdvertisement()
        {
            return await _DbContext.Set<JobAdvertisement>().ToListAsync();
        }
        public async Task<JobAdvertisement> JobAdvertisementEdit(JobAdvertisement JobAdvertisement)
        {
            _DbContext.Set<JobAdvertisement>().Update(JobAdvertisement);
            _DbContext.SaveChangesAsync();
            return JobAdvertisement;
        }

        public async Task<List<JobAdvertisement>> GetJobAdvertisementBySalary(int MaxSalary, int MinSalary)
        {
            return await _DbContext.Set<JobAdvertisement>().Where(p => p.Salary >= MinSalary && p.Salary <= MaxSalary).ToListAsync();
        }

        public async Task<List<JobAdvertisement>> GetJobAdvertisementByCategory(string Category)
        {
            return await _DbContext.Set<JobAdvertisement>().Where(p => p.Category.Name == Category).ToListAsync();
        }

        public async Task<List<JobAdvertisement>> GetJobAdvertisementByTitle(string Title)
        {
            return await _DbContext.Set<JobAdvertisement>().Where(p => p.Title == Title).ToListAsync();
        }

        public async Task<List<JobAdvertisement>> GetJobAdvertisementByCity(string City)
        {
            return await _DbContext.Set<JobAdvertisement>().Where(p => p.Employer.Company.Address.City.Name == City).ToListAsync();

        }

        public async Task<List<JobAdvertisement>> GetJobAdvertisementByDistrict(string District)
        {
            return await _DbContext.Set<JobAdvertisement>().Where(p => p.Employer.Company.Address.District.Name == District).ToListAsync();
        }
        public async Task<List<JobAdvertisement>> GetJobAdvertisementByName(string Name)
        {
            return await _DbContext.Set<JobAdvertisement>().Where(p => p.Name == Name).ToListAsync();
        }

        public async Task<List<JobAdvertisement>> GetJobAdvertisementByWorkingTime(int WorkingTime)
        {
            return await _DbContext.Set<JobAdvertisement>().Where(p => ((int)p.WorkingTime) == WorkingTime).ToListAsync();
        }

        public async Task<List<JobAdvertisement>> GetJobAdvertisementByCompanyName(string CompanyName)
        {
            return await _DbContext.Set<JobAdvertisement>().Where(p => p.Employer.Company.Name == CompanyName).ToListAsync();
        }

        public async Task<List<JobAdvertisement>> JobAdvertisementByCityMinSalaryTitle(string City, int MinSalary, string Title)
        {
            return await _DbContext.Set<JobAdvertisement>().Where(p => p.Employer.Company.Address.City.Name == City && p.Title == Title && p.Salary >= MinSalary).ToListAsync();

        }
    }
}


