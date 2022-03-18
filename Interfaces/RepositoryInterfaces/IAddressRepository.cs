namespace JobForStudents
{

    public interface IAddressRepository
    {
        Task<Address> CreateAddress(Address Address);
        Task<Address> DeleteAddress(int id);
        Task<List<Address>> GetAllAddress();
        Task<Address> FindAddressById(int id);
        Task<Address> AddressEdit(Address Address);
        Task<List<City>> GetAllCity();
        Task<List<District>> GetAllDistrictByCityName(string CityName);
        Task<List<Address>> GetAllAddressByCityName(string CityName);
        Task<List<Address>> GetAllAddressByDistrictName(string DistrictName);
        
        



    }
}