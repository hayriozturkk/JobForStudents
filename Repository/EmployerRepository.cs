using Microsoft.EntityFrameworkCore;

namespace JobForStudents
{
    public class EmployerRepository : IEmployerRepository
    {
        DBContext _DbContext;

        public EmployerRepository()
        {
            _DbContext = new DBContext();
        }

        public async Task<Employer> CreateEmployer(Employer Employer)
        {
            await _DbContext.Set<Employer>().AddAsync(Employer);
            await _DbContext.SaveChangesAsync();
            return Employer;
        }

        public async Task<Employer> DeleteEmployer(int id)
        {
            var deletedEmployer = await _DbContext.Set<Employer>().FirstOrDefaultAsync(x => x.Id == id);
            _DbContext.Set<Employer>().Remove(deletedEmployer);
            _DbContext.SaveChangesAsync();
            return deletedEmployer;

        }

        public async Task<Employer> FindEmployerById(int id)
        {
            return await _DbContext.Set<Employer>().FirstOrDefaultAsync(c => c.Id == id);

        }

        public async Task<List<Employer>> GetAllEmployer()
        {
            return await _DbContext.Set<Employer>().ToListAsync();

        }
        public async Task<Employer> EmployerEdit(Employer Employer)
        {
            _DbContext.Set<Employer>().Update(Employer);
            _DbContext.SaveChangesAsync();
            return Employer;
        }

        public async Task<Employer> GetEmployerByName(string Name)
        {
            return await _DbContext.Set<Employer>().FirstOrDefaultAsync(p => p.Name == Name);
        }

        public async Task<List<Employer>> GetEmployerByGender(int GenderId)
        {
            return await _DbContext.Set<Employer>().Where(p => ((int)p.Gender) == GenderId).ToListAsync();
        }

        public async Task<List<Employer>> GetEmployerCompany(string CompanyName)
        {
            return await _DbContext.Set<Employer>().Where(p => p.Company.Name == CompanyName).ToListAsync();
        }

        public async Task<List<Employer>> GetEmployersByBirthDate(DateTime MaxBirthDate, DateTime MinBirthDate)
        {
            return await _DbContext.Set<Employer>().Where(p => p.BirthDate >= MinBirthDate && p.BirthDate <= MaxBirthDate).ToListAsync();
        }
    }
}


