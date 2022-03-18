namespace JobForStudents
{

    public interface ICompanyRepository
    {
        Task<Company> CreateCompany(Company Company);
        Task<Company> DeleteCompany(int id);
        Task<List<Company>> GetAllCompany();
        Task<Company> FindCompanyById(int id);
        Task<Company> CompanyEdit(Company Company);
        Task<List<Company>> GetCompanyByCategory(string CategoryName);
        Task<List<Company>> GetCompanyByCity(string CityName);
        Task<List<Company>> GetCompanyByDistrict(string DistrictName);
        Task<Company> GetCompanyByName(string Name);
        

    }
}