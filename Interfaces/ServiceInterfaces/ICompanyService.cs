namespace JobForStudents
{

    public interface ICompanyService
    {
        Task<ServiceResponse<Company>> CreateCompany(Company Company);
        Task<ServiceResponse<Company>> DeleteCompany(int id);
        Task<ServiceResponse<List<Company>>> GetAllCompany();
        Task<ServiceResponse<Company>> CompanyEdit(Company Company);
        Task<ServiceResponse<List<Company>>> GetCompanyByCategory(string CategoryName);
        Task<ServiceResponse<List<Company>>> GetCompanyByCity(string CityName);
        Task<ServiceResponse<List<Company>>> GetCompanyByDistrict(string DistrictName);
        Task<ServiceResponse<Company>> GetCompanyByName(string Name);

    }
}