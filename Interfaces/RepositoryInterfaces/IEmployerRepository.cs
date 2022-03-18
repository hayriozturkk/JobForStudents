namespace JobForStudents
{

    public interface IEmployerRepository
    {
        Task<Employer> CreateEmployer(Employer Employer);
        Task<Employer> DeleteEmployer(int id);
        Task<List<Employer>> GetAllEmployer();
        Task<Employer> FindEmployerById(int id);
        Task<Employer> EmployerEdit(Employer Employer);
        Task<Employer> GetEmployerByName(string Name);
        Task<List<Employer>> GetEmployerByGender(int GenderId);
        Task<List<Employer>> GetEmployerCompany(string CompanyName);
        Task<List<Employer>> GetEmployersByBirthDate (DateTime MaxBirthDate, DateTime MinBirthDate);



    }
}