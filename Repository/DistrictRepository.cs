using Microsoft.EntityFrameworkCore;

namespace JobForStudents
{
    public class DistrictRepository : IDistrictRepository
    {
        DBContext _DbContext;

        public DistrictRepository()
        {
            _DbContext = new DBContext();
        }

        public async Task<District> CreateDistrict(District District)
        {
            await _DbContext.Set<District>().AddAsync(District);
            await _DbContext.SaveChangesAsync();
            return District;
        }

        public async Task<District> DeleteDistrict(string name)
        {
            var deletedDistrict = await _DbContext.Set<District>().FirstOrDefaultAsync(x => x.Name == name);
            _DbContext.Set<District>().Remove(deletedDistrict);
            _DbContext.SaveChangesAsync();
            return deletedDistrict;
        }

        public async Task<District> FindDistrictByName(string DistrictName)
        {
            return await _DbContext.Set<District>().FirstOrDefaultAsync(c => c.Name == DistrictName);
        }

        public async Task<List<District>> GetAllDistrict()
        {
            return await _DbContext.Set<District>().ToListAsync();
        }

        public async Task<District> DistrictEdit(District District)
        {
            _DbContext.Set<District>().Update(District);
            _DbContext.SaveChangesAsync();
            return District;

        }
    }
}


