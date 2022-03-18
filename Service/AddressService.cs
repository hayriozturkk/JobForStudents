
namespace JobForStudents
{
    public class AddressService : IAddressService
    {
        private AddressRepository _AddressRepository;
        public AddressService()
        {
            _AddressRepository = new AddressRepository();
        }

        public async Task<ServiceResponse<Address>> CreateAddress(Address Address)
        {
            ServiceResponse<Address> response = new ServiceResponse<Address>();
            var IncomingAddress = await _AddressRepository.FindAddressById(Address.Id);
            if (IncomingAddress == null)
            {
                await _AddressRepository.CreateAddress(Address);
                response.ResponseCode = ResponseCodeEnum.CreateAddressOperationSuccess;
                response.Data = Address;
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.CreateAddressOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<Address>> DeleteAddress(int id)
        {
            ServiceResponse<Address> response = new ServiceResponse<Address>();
            var IncomingAddress = await _AddressRepository.FindAddressById(id);
            if (IncomingAddress != null)
            {
                await _AddressRepository.DeleteAddress(id);
                response.ResponseCode = ResponseCodeEnum.DeleteAddressOperationSuccess;
                response.Data = IncomingAddress;
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.DeleteAddressOperationFail;
                response.Data = null;
                return response;
            }
        }

        public async Task<ServiceResponse<List<Address>>> GetAllAddress()
        {
            ServiceResponse<List<Address>> response = new ServiceResponse<List<Address>>();
            var IncomingFromRepository = await _AddressRepository.GetAllAddress();
            if (IncomingFromRepository.Count > 0)
            {
                response.Data = await _AddressRepository.GetAllAddress();
                response.ResponseCode = ResponseCodeEnum.GetAllAddressOperationSuccess;
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetAllAddressOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<List<City>>> GetAllCity()
        {
            ServiceResponse<List<City>> response = new ServiceResponse<List<City>>();
            var IncomingFromRepository = await _AddressRepository.GetAllCity();
            if (IncomingFromRepository.Count > 0)
            {
                response.Data = await _AddressRepository.GetAllCity();
                response.ResponseCode = ResponseCodeEnum.GetAllCityOperationSuccess;
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetAllCityOperationFail;
                return response;
            }
        }
        public async Task<ServiceResponse<List<District>>> GetAllDistrictByCityName(string CityName)
        {
            ServiceResponse<List<District>> response = new ServiceResponse<List<District>>();
            if (CityName.Length >= 3)
            {
                var IncomingFromRepository = await _AddressRepository.GetAllDistrictByCityName(CityName);
                if (IncomingFromRepository.Count > 0)
                {
                    response.Data = await _AddressRepository.GetAllDistrictByCityName(CityName);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;
                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetAllDistrictByCityNameOperationFail;
                    return response;
                }

            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetAllDistrictByCityNameRequired;
                return response;
            }
        }

        public async Task<ServiceResponse<List<Address>>> GetAllAddressByCityName(string CityName)
        {
            ServiceResponse<List<Address>> response = new ServiceResponse<List<Address>>();
            if (await GetAllAddress() != null && CityName.Length >= 3)
            {
                var IncomingFromRepository = await _AddressRepository.GetAllAddressByCityName(CityName);
                if (IncomingFromRepository.Count > 0)
                {
                    response.Data = await _AddressRepository.GetAllAddressByCityName(CityName);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;
                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetAdressByCityNameOperationFail;
                    return response;
                }

            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetAdressByCityNameRequired;
                return response;
            }
        }

        public async Task<ServiceResponse<List<Address>>> GetAllAddressByDistrictName(string DistrictName)
        {

            ServiceResponse<List<Address>> response = new ServiceResponse<List<Address>>();
            if (await GetAllAddress() != null && DistrictName.Length >= 3)
            {
                var IncomingFromRepository = await _AddressRepository.GetAllAddressByDistrictName(DistrictName);
                if (IncomingFromRepository.Count > 0)
                {
                    response.Data = await _AddressRepository.GetAllAddressByDistrictName(DistrictName);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;

                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetAllAdressByDistrictOperationFail;
                    return response;

                }

            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetAllAdressByDistrictRequired;
                return response;
            }
        }


        public async Task<ServiceResponse<Address>> AddressEdit(Address Address)
        {
            ServiceResponse<Address> response = new ServiceResponse<Address>();
            var editedAddress = _AddressRepository.AddressEdit(Address);
            if (editedAddress != null)
            {
                response.ResponseCode = ResponseCodeEnum.Success;
                response.Data = await editedAddress;
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.AddressEditOperationFail;
                return response;
            }
        }
    }
}



