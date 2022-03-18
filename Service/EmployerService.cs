
namespace JobForStudents
{
    public class EmployerService : IEmployerService
    {
        private EmployerRepository _EmployerRepository;
        public EmployerService()
        {
            _EmployerRepository = new EmployerRepository();
        }

        public async Task<ServiceResponse<Employer>> CreateEmployer(Employer Employer)
        {
            ServiceResponse<Employer> response = new ServiceResponse<Employer>();
            var FromRepositoryEmployer = await _EmployerRepository.FindEmployerById(Employer.Id);
            if (FromRepositoryEmployer == null)
            {
                await _EmployerRepository.CreateEmployer(Employer);
                response.ResponseCode = ResponseCodeEnum.CreateEmployerOperationSuccess;
                response.Data = Employer;
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.CreateEmployerOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<Employer>> DeleteEmployer(int id)
        {
            ServiceResponse<Employer> response = new ServiceResponse<Employer>();
            var FromRepositoryEmployer = await _EmployerRepository.FindEmployerById(id);
            if (FromRepositoryEmployer != null)
            {
                await _EmployerRepository.DeleteEmployer(id);
                response.ResponseCode = ResponseCodeEnum.DeleteEmployerOperationSuccess;
                response.Data = FromRepositoryEmployer;
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.DeleteEmployerOperationFail;
                response.Data = null;
                return response;
            }
        }

        public async Task<ServiceResponse<List<Employer>>> GetAllEmployer()
        {
            ServiceResponse<List<Employer>> response = new ServiceResponse<List<Employer>>();
            try
            {
                response.Data = await _EmployerRepository.GetAllEmployer();
                response.ResponseCode = ResponseCodeEnum.GetAllEmployerOperationSuccess;
                return response;
            }
            catch (Exception e)
            {
                response.Data = null;
                response.ResponseCode = ResponseCodeEnum.GetAllEmployerOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<Employer>> EmployerEdit(Employer Employer)
        {
            ServiceResponse<Employer> response = new ServiceResponse<Employer>();
            var editedEmployer = _EmployerRepository.EmployerEdit(Employer);
            if (editedEmployer != null)
            {

                response.ResponseCode = ResponseCodeEnum.Success;
                response.Data = await editedEmployer;
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.EmployerEditOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<List<Employer>>> GetEmployerByGender(int GenderId)
        {
            ServiceResponse<List<Employer>> response = new ServiceResponse<List<Employer>>();
            if (await GetAllEmployer() != null && GenderId != null)
            {
                List<Employer> IncomingFromRepository = await _EmployerRepository.GetEmployerByGender(GenderId);
                if ( IncomingFromRepository.Count != 0)
                {
                    response.Data = await _EmployerRepository.GetEmployerByGender(GenderId);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;
                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetEmployerByGenderOperationFail;
                    return response;
                }

            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetEmployerByGenderRequired;
                return response;
            }
        }

        public async Task<ServiceResponse<List<Employer>>> GetEmployerCompany(string CompanyName)
        {
            ServiceResponse<List<Employer>> response = new ServiceResponse<List<Employer>>();
            if (await GetAllEmployer() != null && CompanyName.Length >= 3)
            {
                List<Employer> IncomingFromRepository = await _EmployerRepository.GetEmployerCompany(CompanyName);
                if ( IncomingFromRepository.Count != 0)
                {
                    response.Data = await _EmployerRepository.GetEmployerCompany(CompanyName);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;
                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetEmployerCompanyOperationFail;
                    return response;
                }

            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetEmployerCompanyRequired;
                return response;
            }
        }

        public async Task<ServiceResponse<Employer>> GetEmployerByName(string Name)
        {
            ServiceResponse<Employer> response = new ServiceResponse<Employer>();
            if (await GetAllEmployer() != null && Name.Length >= 3)
            {
                Employer IncomingFromRepository = await _EmployerRepository.GetEmployerByName(Name);
                if ( IncomingFromRepository != null)
                {
                    response.Data = await _EmployerRepository.GetEmployerByName(Name);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;
                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetEmployerByNameOperationFail;
                    return response;
                }
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetEmployerByNameRequired;
                return response;
            }
        }

        public async Task<ServiceResponse<List<Employer>>> GetEmployersByBirthDate(DateTime MaxBirthDate, DateTime MinBirthDate)
        {
            ServiceResponse<List<Employer>> response = new ServiceResponse<List<Employer>>();
            if (await GetAllEmployer() != null && (MaxBirthDate != null || MinBirthDate != null))
            {
                List<Employer> IncomingFromRepository = await _EmployerRepository.GetEmployersByBirthDate(MaxBirthDate, MinBirthDate);
                if ( IncomingFromRepository.Count != 0)
                {
                    response.Data = await _EmployerRepository.GetEmployersByBirthDate(MaxBirthDate, MinBirthDate);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;
                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetEmployersByBirthDateOperationFail;
                    return response;
                }

            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetEmployersByBirthDateRequired;
                return response;
            }
        }
    }
}



