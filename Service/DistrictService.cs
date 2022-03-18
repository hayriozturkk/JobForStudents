
namespace JobForStudents
{
    public class DistrictService : IDistrictService
    {
        private DistrictRepository _districtRepository;
        public DistrictService()
        {
            _districtRepository = new DistrictRepository();
        }

        public async Task<ServiceResponse<District>> CreateDistrict(District District)
        {
            ServiceResponse<District> response = new ServiceResponse<District>();
            var FromRepositoryDistrict = await _districtRepository.FindDistrictByName(District.Name);
            if (FromRepositoryDistrict == null)
            {
                await _districtRepository.CreateDistrict(District);
                response.ResponseCode= ResponseCodeEnum.CreateDistrictOperationSuccess;
                response.Data=District;
                return response;
            }
            else
            {
                response.ResponseCode= ResponseCodeEnum.CreateDistrictOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<District>> DeleteDistrict(string name)
        {
            ServiceResponse<District> response = new ServiceResponse<District>();
            var FromRepositoryDistrict = await _districtRepository.FindDistrictByName(name);
            if (FromRepositoryDistrict != null)
            {
                await _districtRepository.DeleteDistrict(name);
                response.ResponseCode = ResponseCodeEnum.DeleteDistrictOperationSuccess;
                response.Data=FromRepositoryDistrict;
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.DeleteDistrictOperationFail;
                response.Data=null;
                return response;
            }
        }

        public async Task<ServiceResponse<List<District>>> GetAllDistrict()
        {

            ServiceResponse<List<District>> response = new ServiceResponse<List<District>>();
            try
            {
                response.Data = await _districtRepository.GetAllDistrict();
                response.ResponseCode = ResponseCodeEnum.GetAllDistrictsOperationSuccess;
                return response;
            }
            catch (Exception e)
            {
                response.Data = null;
                response.ResponseCode = ResponseCodeEnum.GetAllDistrictsOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<District>> DistrictEdit(District District)
        {
            ServiceResponse<District> response = new ServiceResponse<District>();
            var editedDistrict = _districtRepository.DistrictEdit(District);
            if (editedDistrict != null)
            {  
                response.ResponseCode = ResponseCodeEnum.Success;
                response.Data= await editedDistrict; 
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetAllDistrictsOperationFail;
                return response;
            }
        }
    }
}



