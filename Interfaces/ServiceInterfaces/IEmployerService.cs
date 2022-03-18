namespace JobForStudents
{

    public interface IEmployerService
    {
        Task<ServiceResponse<Employer>> CreateEmployer(Employer Employer);
        Task<ServiceResponse<Employer>> DeleteEmployer(int id);
        Task<ServiceResponse<List<Employer>>> GetAllEmployer();
        Task<ServiceResponse<Employer>> EmployerEdit(Employer Employer);
        Task<ServiceResponse<List<Employer>>> GetEmployerByGender(int GenderId);
        Task<ServiceResponse<List<Employer>>> GetEmployerCompany(string CompanyName);
        Task<ServiceResponse<Employer>> GetEmployerByName(string Name);
        Task<ServiceResponse<List<Employer>>> GetEmployersByBirthDate (DateTime MaxBirthDate, DateTime MinBirthDate);




    }
}