namespace JobForStudents
{

    public interface IAddressService
    {
        Task<ServiceResponse<Address>> CreateAddress(Address Address);
        Task<ServiceResponse<Address>> DeleteAddress(int id);
        Task<ServiceResponse<List<Address>>> GetAllAddress();
        Task<ServiceResponse<Address>> AddressEdit(Address Address);
        Task<ServiceResponse<List<City>>> GetAllCity();
        Task<ServiceResponse<List<District>>> GetAllDistrictByCityName(string CityName);
        Task<ServiceResponse<List<Address>>> GetAllAddressByCityName(string CityName);
        Task<ServiceResponse<List<Address>>> GetAllAddressByDistrictName(string DistrictName);





    }
}