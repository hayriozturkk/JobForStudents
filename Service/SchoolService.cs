
namespace JobForStudents
{
    public class SchoolService : ISchoolService
    {
        private SchoolRepository _SchoolRepository;
        public SchoolService()
        {
            _SchoolRepository = new SchoolRepository();
        }

        public async Task<ServiceResponse<School>> CreateSchool(School School)
        {
            ServiceResponse<School> response = new ServiceResponse<School>();
            var FromRepositorySchool= await _SchoolRepository.FindSchoolById(School.Id);
            if (FromRepositorySchool== null)
            {
                await _SchoolRepository.CreateSchool(School);
                response.ResponseCode= ResponseCodeEnum.CreateSchoolOperationSuccess;
                response.Data=School;
                return response;
            }
            else
            {
                response.ResponseCode= ResponseCodeEnum.CreateSchoolOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<School>> DeleteSchool(int id)
        {
            ServiceResponse<School> response = new ServiceResponse<School>();
            var FromRepositorySchool = await _SchoolRepository.FindSchoolById(id);
            if (FromRepositorySchool != null)
            {
                await _SchoolRepository.DeleteSchool(id);
                response.ResponseCode = ResponseCodeEnum.DeleteSchoolOperationSuccess;
                response.Data=FromRepositorySchool;
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.DeleteSchoolOperationFail;
                response.Data=null;
                return response;
            }
        }

        public async Task<ServiceResponse<List<School>>> GetAllSchool()
        {
            ServiceResponse<List<School>> response = new ServiceResponse<List<School>>();
            try
            {
                response.Data = await _SchoolRepository.GetAllSchool();
                response.ResponseCode = ResponseCodeEnum.GetAllSchoolOperationSuccess;
                return response;
            }
            catch (Exception e)
            {
                response.Data = null;
                response.ResponseCode = ResponseCodeEnum.GetAllSchoolOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<School>> SchoolEdit(School School)
        {
            ServiceResponse<School> response = new ServiceResponse<School>();
            var editedSchool = _SchoolRepository.SchoolEdit(School);

            if (editedSchool != null)
            {
                
                response.ResponseCode = ResponseCodeEnum.Success;
                response.Data= await editedSchool; 
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.SchoolEditOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<List<School>>> GetSchoolsByCityName(string CityName)
        {
            ServiceResponse<List<School>> response = new ServiceResponse<List<School>>();
            if (await GetAllSchool() != null && CityName.Length >= 3)
            {
                var IncomingFromRepository = await _SchoolRepository.GetSchoolsByCityName(CityName);
                if ( IncomingFromRepository.Count > 0 )
                {
                    response.Data = await _SchoolRepository.GetSchoolsByCityName(CityName);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;

                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetSchoolsByCityOperationFail;
                    return response;

                }

            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetSchoolsByCityRequired;
                return response;
            }
        }

        public async Task<ServiceResponse<List<School>>> GetSchoolsByDistrictName(string DistrictName)
        {
            ServiceResponse<List<School>> response = new ServiceResponse<List<School>>();
            if (await GetAllSchool() != null && DistrictName.Length >= 3)
            {
                 var IncomingFromRepository = await _SchoolRepository.GetSchoolsByDistrictName(DistrictName);
                if (IncomingFromRepository.Count>0)
                {
                    response.Data = await _SchoolRepository.GetSchoolsByDistrictName(DistrictName);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;

                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetSchoolsByDistrictOperationFail;
                    return response;

                }

            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetSchoolsByDistrictRequired;
                return response;
            }
        }

        public async Task<ServiceResponse<School>> GetSchoolByName(string SchoolName)
        {
            ServiceResponse<School> response = new ServiceResponse<School>();
            if (await GetAllSchool() != null && SchoolName.Length >= 3)
            {
                var IncomingFromRepository = await _SchoolRepository.GetSchoolByName(SchoolName);
                if (IncomingFromRepository != null)
                {
                    response.Data = await _SchoolRepository.GetSchoolByName(SchoolName);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;

                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetSchoolByNameOperationFail;
                    return response;

                }

            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetSchoolByNameRequired;
                return response;
            }
        }
    }


}



