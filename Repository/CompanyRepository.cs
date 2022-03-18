using Microsoft.EntityFrameworkCore;

namespace JobForStudents
{
    public class CompanyRepository : ICompanyRepository
    {
        DBContext _DbContext;

        public CompanyRepository()
        {
            _DbContext = new DBContext();
        }

        public async Task<Company> CreateCompany(Company Company)
        {
            await _DbContext.Set<Company>().AddAsync(Company);
            await _DbContext.SaveChangesAsync();
            return Company;
        }

        public async Task<Company> DeleteCompany(int id)
        {
            var deletedCompany = await _DbContext.Set<Company>().FirstOrDefaultAsync(x => x.Id == id);
            _DbContext.Set<Company>().Remove(deletedCompany);
            _DbContext.SaveChangesAsync();
            return deletedCompany;
        }

        public async Task<Company> FindCompanyById(int id)
        {
            return await _DbContext.Set<Company>().FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<Company>> GetAllCompany()
        {
            return await _DbContext.Set<Company>().ToListAsync();
        }
        public async Task<Company> CompanyEdit(Company Company)
        {
            _DbContext.Set<Company>().Update(Company);
            _DbContext.SaveChangesAsync();
            return Company;
        }

        public async Task<List<Company>> GetCompanyByCategory(string CategoryName)
        {
            return await _DbContext.Set<Company>().Where(c => c.Category.Name == CategoryName).ToListAsync();
        }

        public async Task<List<Company>> GetCompanyByCity(string CityName)
        {
            return await _DbContext.Set<Company>().Where(c => c.Address.City.Name == CityName).ToListAsync();
        }

        public async Task<List<Company>> GetCompanyByDistrict(string DistrictName)
        {
            return await _DbContext.Set<Company>().Where(c => c.Address.District.Name == DistrictName).ToListAsync();
        }
        public async Task<Company> GetCompanyByName(string Name)
        {
            return await _DbContext.Set<Company>().FirstOrDefaultAsync(c => c.Name == Name);
        }
    }



}


