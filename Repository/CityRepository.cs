using Microsoft.EntityFrameworkCore;

namespace JobForStudents
{
    public class CityRepository : ICityRepository
    {
        DBContext _DbContext;

        public CityRepository()
        {
            _DbContext = new DBContext();
        }

        public async Task<City> CreateCity(City City)
        {
            await _DbContext.Set<City>().AddAsync(City);
            await _DbContext.SaveChangesAsync();
            return City;
        }

        public async Task<City> DeleteCity(string name)
        {
            var deletedCity = await _DbContext.Set<City>().FirstOrDefaultAsync(x => x.Name == name);
            _DbContext.Set<City>().Remove(deletedCity);
            _DbContext.SaveChangesAsync();
            return deletedCity;
        }

        public async Task<City> FindCityByName(string CityName)
        {
            return await _DbContext.Set<City>().FirstOrDefaultAsync(c => c.Name == CityName);
        }

        public async Task<List<City>> GetAllCity()
        {
            return await _DbContext.Set<City>().ToListAsync();
        }
        public async Task<City> CityEdit(City City)
        {
            _DbContext.Set<City>().Update(City);
            _DbContext.SaveChangesAsync();
            return City;
        }
    }



}


