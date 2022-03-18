namespace JobForStudents
{

    public interface IJobAdvertisementRepository
    {
        Task<JobAdvertisement> CreateJobAdvertisement(JobAdvertisement JobAdvertisement);
        Task<JobAdvertisement> DeleteJobAdvertisement(int id);
        Task<List<JobAdvertisement>> GetAllJobAdvertisement();
        Task<JobAdvertisement> FindJobAdvertisementById(int id);
        Task<JobAdvertisement> JobAdvertisementEdit(JobAdvertisement JobAdvertisement);
        Task<List<JobAdvertisement>> GetJobAdvertisementBySalary(int MaxSalary,int MinSalary);
        Task<List<JobAdvertisement>> GetJobAdvertisementByCategory(string Category);
        Task<List<JobAdvertisement>> GetJobAdvertisementByTitle(string Title);
        Task<List<JobAdvertisement>> GetJobAdvertisementByCity(string City);
        Task<List<JobAdvertisement>> GetJobAdvertisementByDistrict(string District);
        Task<List<JobAdvertisement>> GetJobAdvertisementByName(string Name);
        Task<List<JobAdvertisement>> GetJobAdvertisementByWorkingTime(int WorkingTime);
        Task<List<JobAdvertisement>> GetJobAdvertisementByCompanyName(string CompanyName);
        Task<List<JobAdvertisement>> JobAdvertisementByCityMinSalaryTitle(string City,int MinSalary,string Title);
        



    }
}