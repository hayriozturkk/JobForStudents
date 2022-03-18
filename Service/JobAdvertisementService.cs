
namespace JobForStudents
{
    public class JobAdvertisementService : IJobAdvertisementService
    {
        private JobAdvertisementRepository _JobAdvertisementRepository;
        public JobAdvertisementService()
        {
            _JobAdvertisementRepository = new JobAdvertisementRepository();
        }

        public async Task<ServiceResponse<JobAdvertisement>> CreateJobAdvertisement(JobAdvertisement JobAdvertisement)
        {
            ServiceResponse<JobAdvertisement> response = new ServiceResponse<JobAdvertisement>();
            var FromRepositoryJobAdvertisement = await _JobAdvertisementRepository.FindJobAdvertisementById(JobAdvertisement.Id);
            if (FromRepositoryJobAdvertisement == null)
            {
                await _JobAdvertisementRepository.CreateJobAdvertisement(JobAdvertisement);
                response.ResponseCode = ResponseCodeEnum.CreateJobAdvertisementOperationSuccess;
                response.Data = JobAdvertisement;
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.CreateJobAdvertisementOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<JobAdvertisement>> DeleteJobAdvertisement(int id)
        {
            ServiceResponse<JobAdvertisement> response = new ServiceResponse<JobAdvertisement>();
            var FromRepositoryJobAdvertisement = await _JobAdvertisementRepository.FindJobAdvertisementById(id);
            if (FromRepositoryJobAdvertisement != null)
            {
                await _JobAdvertisementRepository.DeleteJobAdvertisement(id);
                response.ResponseCode = ResponseCodeEnum.DeleteJobAdvertisementOperationSuccess;
                response.Data = FromRepositoryJobAdvertisement;
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.DeleteJobAdvertisementOperationFail;
                response.Data = null;
                return response;
            }
        }

        public async Task<ServiceResponse<List<JobAdvertisement>>> GetAllJobAdvertisement()
        {
            ServiceResponse<List<JobAdvertisement>> response = new ServiceResponse<List<JobAdvertisement>>();
            try
            {
                response.Data = await _JobAdvertisementRepository.GetAllJobAdvertisement();
                response.ResponseCode = ResponseCodeEnum.GetAllJobAdvertisementOperationSuccess;
                return response;
            }
            catch (Exception e)
            {
                response.Data = null;
                response.ResponseCode = ResponseCodeEnum.GetAllJobAdvertisementOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<JobAdvertisement>> JobAdvertisementEdit(JobAdvertisement JobAdvertisement)
        {
            ServiceResponse<JobAdvertisement> response = new ServiceResponse<JobAdvertisement>();
            var editedJobAdvertisement = _JobAdvertisementRepository.JobAdvertisementEdit(JobAdvertisement);
            if (editedJobAdvertisement != null)
            {
                response.ResponseCode = ResponseCodeEnum.Success;
                response.Data = await editedJobAdvertisement;
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.JobAdvertisementEditOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<List<JobAdvertisement>>> GetJobAdvertisementBySalary(int MaxSalary, int MinSalary)
        {
           ServiceResponse<List<JobAdvertisement>> response = new ServiceResponse<List<JobAdvertisement>>();
            if (await GetAllJobAdvertisement() != null  && MaxSalary >0  && MinSalary > 0 && MaxSalary > MinSalary)
            {
                List<JobAdvertisement> IncomingFromRepository = await _JobAdvertisementRepository.GetJobAdvertisementBySalary(MaxSalary, MinSalary);
                if (IncomingFromRepository.Count != 0)
                {
                    response.Data =  await _JobAdvertisementRepository.GetJobAdvertisementBySalary(MaxSalary, MinSalary);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;
                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetJobAdvertisementBySalaryOperationFail;
                    return response;
                }
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetJobAdvertisementBySalaryRequired;
                return response;
            }
        }

        public async Task<ServiceResponse<List<JobAdvertisement>>> GetJobAdvertisementByCategory(string Category)
        {
            ServiceResponse<List<JobAdvertisement>> response = new ServiceResponse<List<JobAdvertisement>>();
            if (await GetAllJobAdvertisement() != null && Category.Length >= 3)
            {
                List<JobAdvertisement> IncomingFromRepository = await _JobAdvertisementRepository.GetJobAdvertisementByCategory(Category);
                if (IncomingFromRepository.Count != 0)
                {
                    response.Data =  await _JobAdvertisementRepository.GetJobAdvertisementByCategory(Category);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;
                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetJobAdvertisementByCategoryOperationFail;
                    return response;
                }
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetJobAdvertisementByCategoryRequired;
                return response;
            }
        }

        public async Task<ServiceResponse<List<JobAdvertisement>>> GetJobAdvertisementByTitle(string Title)
        {
            ServiceResponse<List<JobAdvertisement>> response = new ServiceResponse<List<JobAdvertisement>>();
            if (await GetAllJobAdvertisement() != null && Title.Length >= 3)
            {
                List<JobAdvertisement> IncomingFromRepository = await _JobAdvertisementRepository.GetJobAdvertisementByTitle(Title);
                if (IncomingFromRepository.Count != 0)
                {
                    response.Data = await _JobAdvertisementRepository.GetJobAdvertisementByTitle(Title);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;
                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetJobAdvertisementByTitleOperationFail;
                    return response;
                }
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetJobAdvertisementByTitleRequired;
                return response;
            }
        }

        public async Task<ServiceResponse<List<JobAdvertisement>>> GetJobAdvertisementByCity(string City)
        {

            ServiceResponse<List<JobAdvertisement>> response = new ServiceResponse<List<JobAdvertisement>>();
            if (await GetAllJobAdvertisement() != null && City.Length >= 3)
            {
                List<JobAdvertisement> IncomingFromRepository = await _JobAdvertisementRepository.GetJobAdvertisementByCity(City);
                if (IncomingFromRepository.Count != 0)
                {
                    response.Data = await _JobAdvertisementRepository.GetJobAdvertisementByCity(City);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;
                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetJobAdvertisementByCityOperationFail;
                    return response;
                }
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetJobAdvertisementByCityRequired;
                return response;
            }
        }

        public async Task<ServiceResponse<List<JobAdvertisement>>> GetJobAdvertisementByDistrict(string District)
        {
            ServiceResponse<List<JobAdvertisement>> response = new ServiceResponse<List<JobAdvertisement>>();
            if (await GetAllJobAdvertisement() != null && District.Length >= 3)
            {
                List<JobAdvertisement> IncomingFromRepository = await _JobAdvertisementRepository.GetJobAdvertisementByDistrict(District);
                if (IncomingFromRepository.Count != 0)
                {
                    response.Data = await _JobAdvertisementRepository.GetJobAdvertisementByDistrict(District);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;
                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetJobAdvertisementByDistrictOperationFail;
                    return response;
                }
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetJobAdvertisementByDistrictRequired;
                return response;
            }
        }

        public async Task<ServiceResponse<List<JobAdvertisement>>> GetJobAdvertisementByName(string Name)
        {
            ServiceResponse<List<JobAdvertisement>> response = new ServiceResponse<List<JobAdvertisement>>();
            if (await GetAllJobAdvertisement() != null && Name.Length >= 3)
            {
                List<JobAdvertisement> IncomingFromRepository = await _JobAdvertisementRepository.GetJobAdvertisementByName(Name);
                if (IncomingFromRepository.Count != 0)
                {
                    response.Data = await _JobAdvertisementRepository.GetJobAdvertisementByName(Name);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;
                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetJobAdvertisementByNameOperationFail;
                    return response;
                }
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetJobAdvertisementByNameRequired;
                return response;
            }
        }

        public async Task<ServiceResponse<List<JobAdvertisement>>> GetJobAdvertisementByWorkingTime(int WorkingTime)
        {
            ServiceResponse<List<JobAdvertisement>> response = new ServiceResponse<List<JobAdvertisement>>();
            if (await GetAllJobAdvertisement() != null && WorkingTime != null && WorkingTime<2)
            {
                List<JobAdvertisement> IncomingFromRepository = await _JobAdvertisementRepository.GetJobAdvertisementByWorkingTime(WorkingTime);
                if (IncomingFromRepository.Count != 0)
                {
                    response.Data = await _JobAdvertisementRepository.GetJobAdvertisementByWorkingTime(WorkingTime);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;
                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetJobAdvertisementByWorkingTimeOperationFail;
                    return response;
                }
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetJobAdvertisementByWorkingTimeRequired;
                return response;
            }
        }
        public async Task<ServiceResponse<List<JobAdvertisement>>> GetJobAdvertisementByCompanyName(string CompanyName)
        {
            ServiceResponse<List<JobAdvertisement>> response = new ServiceResponse<List<JobAdvertisement>>();
            if (await GetAllJobAdvertisement() != null && CompanyName.Length >= 3)
            {
                List<JobAdvertisement> IncomingFromRepository = await _JobAdvertisementRepository.GetJobAdvertisementByCompanyName(CompanyName);
                if (IncomingFromRepository.Count != 0)
                {
                    response.Data = await _JobAdvertisementRepository.GetJobAdvertisementByCompanyName(CompanyName);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;
                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.GetJobAdvertisementByCompanyNameOperationFail;
                    return response;
                }
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetJobAdvertisementByCompanyNameRequired;
                return response;
            }

        }

        public async Task<ServiceResponse<List<JobAdvertisement>>> JobAdvertisementByCityMinSalaryTitle(string City, int MinSalary, string Title)
        {
            ServiceResponse<List<JobAdvertisement>> response = new ServiceResponse<List<JobAdvertisement>>();
            if (await GetAllJobAdvertisement() != null && City.Length >= 3 && Title.Length >= 3 && MinSalary > 0)
            {
                List<JobAdvertisement> IncomingFromRepository = await _JobAdvertisementRepository.JobAdvertisementByCityMinSalaryTitle(City, MinSalary, Title);
                if (IncomingFromRepository.Count != 0)
                {
                    response.Data = await _JobAdvertisementRepository.JobAdvertisementByCityMinSalaryTitle(City, MinSalary, Title);
                    response.ResponseCode = ResponseCodeEnum.Success;
                    return response;

                }
                else
                {
                    response.ResponseCode = ResponseCodeEnum.JobAdvertisementByCityMinSalaryTitleOperationFail;
                    return response;

                }

            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.JobAdvertisementByCityMinSalaryTitleRequired;
                return response;
            }
        }
    }
}






