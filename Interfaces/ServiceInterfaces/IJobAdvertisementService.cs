namespace JobForStudents
{

    public interface IJobAdvertisementService
    {
        Task<ServiceResponse<JobAdvertisement>> CreateJobAdvertisement(JobAdvertisement JobAdvertisement);
        Task<ServiceResponse<JobAdvertisement>> DeleteJobAdvertisement(int id);
        Task<ServiceResponse<List<JobAdvertisement>>> GetAllJobAdvertisement();
        Task<ServiceResponse<JobAdvertisement>> JobAdvertisementEdit(JobAdvertisement JobAdvertisement);
        Task<ServiceResponse<List<JobAdvertisement>>> GetJobAdvertisementBySalary(int MaxSalary,int MinSalary);
        Task<ServiceResponse<List<JobAdvertisement>>> GetJobAdvertisementByCategory(string Category);
        Task<ServiceResponse<List<JobAdvertisement>>> GetJobAdvertisementByTitle(string Title);
        Task<ServiceResponse<List<JobAdvertisement>>> GetJobAdvertisementByCity(string City);
        Task<ServiceResponse<List<JobAdvertisement>>> GetJobAdvertisementByDistrict(string District);
        Task<ServiceResponse<List<JobAdvertisement>>> GetJobAdvertisementByName(string Name);
        Task<ServiceResponse<List<JobAdvertisement>>> GetJobAdvertisementByWorkingTime(int WorkingTime);
        Task<ServiceResponse<List<JobAdvertisement>>> GetJobAdvertisementByCompanyName(string CompanyName);
        Task<ServiceResponse<List<JobAdvertisement>>> JobAdvertisementByCityMinSalaryTitle(string City,int MinSalary,string Title);


    }
}