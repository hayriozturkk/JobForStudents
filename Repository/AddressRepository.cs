using Microsoft.EntityFrameworkCore;

namespace JobForStudents
{
    public class AddressRepository : IAddressRepository
    {
        DBContext _DbContext;

        public AddressRepository()
        {
            _DbContext = new DBContext();
        }

        public async Task<Address> CreateAddress(Address Address)
        {
            await _DbContext.Set<Address>().AddAsync(Address);
            await _DbContext.SaveChangesAsync();
            return Address;
        }

        public async Task<Address> DeleteAddress(int id)
        {
            var deletedAddress = await _DbContext.Set<Address>().FirstOrDefaultAsync(x => x.Id == id);
            _DbContext.Set<Address>().Remove(deletedAddress);
            _DbContext.SaveChangesAsync();
            return deletedAddress;
        }

        public async Task<Address> FindAddressById(int id)
        {
            return await _DbContext.Set<Address>().FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<Address>> GetAllAddress()
        {
            return await _DbContext.Set<Address>().ToListAsync();
        }

        public async Task<List<City>> GetAllCity()
        {
            return await _DbContext.Set<City>().ToListAsync();
        }
        public async Task<List<District>> GetAllDistrictByCityName(string CityName)
        {
            return await _DbContext.Set<District>().Where(d => d.City.Name == CityName).ToListAsync();
        }

        public async Task<List<Address>> GetAllAddressByCityName(string CityName)
        {
            return await _DbContext.Set<Address>().Where(d => d.City.Name == CityName).ToListAsync();
        }

        public async Task<List<Address>> GetAllAddressByDistrictName(string DistrictName)
        {
            return await _DbContext.Set<Address>().Where(d => d.District.Name == DistrictName).ToListAsync();
        }
        public async Task<Address> AddressEdit(Address Address)
        {
            _DbContext.Set<Address>().Update(Address);
            _DbContext.SaveChangesAsync();
            return Address;
        }
    }
}


