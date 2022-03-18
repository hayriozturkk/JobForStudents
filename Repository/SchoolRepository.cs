using Microsoft.EntityFrameworkCore;

namespace JobForStudents
{
    public class SchoolRepository : ISchoolRepository
    {
        DBContext _DbContext;

        public SchoolRepository()
        {
            _DbContext = new DBContext();
        }

        public async Task<School> CreateSchool(School School)
        {
            await _DbContext.Set<School>().AddAsync(School);
            await _DbContext.SaveChangesAsync();
            return School;

        }

        public async Task<School> DeleteSchool(int id)
        {
            var deletedSchool = await _DbContext.Set<School>().FirstOrDefaultAsync(x => x.Id == id);
            _DbContext.Set<School>().Remove(deletedSchool);
            _DbContext.SaveChangesAsync();
            return deletedSchool;

        }

        public async Task<School> FindSchoolById(int id)
        {
            return await _DbContext.Set<School>().FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<School>> GetAllSchool()
        {
            return await _DbContext.Set<School>().ToListAsync();
        }
        public async Task<School> SchoolEdit(School School)
        {
            _DbContext.Set<School>().Update(School);
            _DbContext.SaveChangesAsync();
            return School;
        }
        public async Task<School> GetSchoolByName(string SchoolName)
        {
            return  await _DbContext.Set<School>().FirstOrDefaultAsync(p => p.Name == SchoolName);
        }

        public async Task<List<School>> GetSchoolsByCityName(string CityName)
        {
            return await _DbContext.Set<School>().Where(p => p.Address.City.Name == CityName).ToListAsync();
        }
        public async Task<List<School>> GetSchoolsByDistrictName(string DistrictName)
        {
            return await _DbContext.Set<School>().Where(p => p.Address.District.Name == DistrictName).ToListAsync();
        }
    }
}