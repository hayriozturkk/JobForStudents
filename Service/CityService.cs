
namespace JobForStudents
{
    public class CityService : ICityService
    {
        private CityRepository _CityRepository;
        public CityService()
        {
            _CityRepository = new CityRepository();
        }
        
        public async Task<ServiceResponse<City>> CreateCity(City City)
        {
            ServiceResponse<City> response = new ServiceResponse<City>();
            var IncomingCity = await _CityRepository.FindCityByName(City.Name);
            if (IncomingCity == null)
            {
                await _CityRepository.CreateCity(City);
                response.ResponseCode= ResponseCodeEnum.CreateCityOperationSuccess;
                response.Data=City;
                return response;
            }
            else
            {
                response.ResponseCode= ResponseCodeEnum.CreateCityOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<City>> DeleteCity(string name)
        {
            ServiceResponse<City> response = new ServiceResponse<City>();
            var IncomingCity = await _CityRepository.FindCityByName(name);
            if (IncomingCity != null)
            {
                await _CityRepository.DeleteCity(name);
                response.ResponseCode = ResponseCodeEnum.DeleteCityOperationSuccess;
                response.Data=IncomingCity;
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.DeleteCityOperationFail;
                response.Data=null;
                return response;
            }
        }

        public async Task<ServiceResponse<List<City>>> GetAllCity()
        {
            ServiceResponse<List<City>> response = new ServiceResponse<List<City>>();
            try
            {
                response.Data = await _CityRepository.GetAllCity();
                response.ResponseCode = ResponseCodeEnum.GetAllCityOperationSuccess;
                return response;
            }
            catch (Exception e)
            {
                response.Data = null;
                response.ResponseCode = ResponseCodeEnum.GetAllCityOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<City>> CitytEdit(City City)
        {
            ServiceResponse<City> response = new ServiceResponse<City>();
            var editedCity = _CityRepository.CityEdit(City);

            if (editedCity != null)
            {
                response.ResponseCode = ResponseCodeEnum.Success;
                response.Data= await editedCity; 
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.CityEditOperationFail;
                return response;
            }
        }
    }


}



