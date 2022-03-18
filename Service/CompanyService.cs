
namespace JobForStudents
{
    public class CompanyService : ICompanyService
    {
        private CompanyRepository _CompanyRepository;
        public CompanyService()
        {
            _CompanyRepository = new CompanyRepository();
        }

        public async Task<ServiceResponse<Company>> CreateCompany(Company Company)
        {
            ServiceResponse<Company> response = new ServiceResponse<Company>();
            var FromRepositoryCompany = await _CompanyRepository.FindCompanyById(Company.Id);
            if (FromRepositoryCompany == null)
            {
                await _CompanyRepository.CreateCompany(Company);
                response.ResponseCode = ResponseCodeEnum.CreateCompanyOperationSuccess;
                response.Data = Company;
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.CreateCompanyOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<Company>> DeleteCompany(int id)
        {
            ServiceResponse<Company> response = new ServiceResponse<Company>();
            var FromRepositoryCompany = await _CompanyRepository.FindCompanyById(id);
            if (FromRepositoryCompany != null)
            {
                await _CompanyRepository.DeleteCompany(id);
                response.ResponseCode = ResponseCodeEnum.DeleteCompanyOperationSuccess;
                response.Data = FromRepositoryCompany;
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.DeleteCompanyOperationFail;
                response.Data = null;
                return response;
            }
        }

        public async Task<ServiceResponse<List<Company>>> GetAllCompany()
        {
            ServiceResponse<List<Company>> response = new ServiceResponse<List<Company>>();
            try
            {
                response.Data = await _CompanyRepository.GetAllCompany();
                response.ResponseCode = ResponseCodeEnum.GetAllCompanyOperationSuccess;
                return response;
            }
            catch (Exception e)
            {
                response.Data = null;
                response.ResponseCode = ResponseCodeEnum.GetAllCompanyOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<Company>> CompanyEdit(Company Company)
        {
            ServiceResponse<Company> response = new ServiceResponse<Company>();
            var editedCompany = _CompanyRepository.CompanyEdit(Company);
            if (editedCompany != null)
            {
                response.ResponseCode = ResponseCodeEnum.Success;
                response.Data = await editedCompany;
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.CompanyEditOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<List<Company>>> GetCompanyByCategory(string CategoryName)
        {
            ServiceResponse<List<Company>> response = new ServiceResponse<List<Company>>();
            if (await GetAllCompany() != null && CategoryName.Length >= 3)
            {
                List<Company> IncomingFromRepository = await _CompanyRepository.GetCompanyByCategory(CategoryName);
                if ( IncomingFromRepository.Count != 0)
                {
                    response.Data = await _CompanyRepository.GetCompanyByCategory(CategoryName);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;
                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetCompanyByCategoryOperationFail;
                    return response;
                }

            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetCompanyByCategoryRequired;
                return response;
            }
        }

        public async Task<ServiceResponse<List<Company>>> GetCompanyByCity(string CityName)
        {
            ServiceResponse<List<Company>> response = new ServiceResponse<List<Company>>();
            if (await GetAllCompany() != null && CityName.Length >= 3)
            {
                List<Company> IncomingFromRepository = await _CompanyRepository.GetCompanyByCity(CityName);
                if (IncomingFromRepository.Count != 0)
                {
                    response.Data = await _CompanyRepository.GetCompanyByCity(CityName);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;
                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetCompanyByCityOperationFail;
                    return response;
                }

            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetCompanyByCityRequired;
                return response;
            }
        }

        public async Task<ServiceResponse<List<Company>>> GetCompanyByDistrict(string DistrictName)
        {
            ServiceResponse<List<Company>> response = new ServiceResponse<List<Company>>();
            if (await GetAllCompany() != null && DistrictName.Length >= 3)
            {
                List<Company> IncomingFromRepository = await _CompanyRepository.GetCompanyByDistrict(DistrictName);
                if (IncomingFromRepository.Count != 0)
                {
                    response.Data = await _CompanyRepository.GetCompanyByDistrict(DistrictName);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;
                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetCompanyByDistrictOperationFail;
                    return response;
                }
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetCompanyByDistrictRequired;
                return response;
            }
        }
        public async Task<ServiceResponse<Company>> GetCompanyByName(string Name)
        {
            ServiceResponse<Company> response = new ServiceResponse<Company>();
            if (await GetAllCompany() != null && Name.Length >= 3)
            {
                Company IncomingFromRepository = await _CompanyRepository.GetCompanyByName(Name);
                if ( IncomingFromRepository != null )
                {
                    response.Data = await _CompanyRepository.GetCompanyByName(Name);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;
                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetCompanyByNameOperationFail;
                    return response;
                }

            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetCompanyByNameRequired;
                return response;
            }
        }
    }
}



