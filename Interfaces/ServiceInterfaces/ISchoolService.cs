namespace JobForStudents
{

    public interface ISchoolService
    {
        Task<ServiceResponse<School>> CreateSchool(School School);
        Task<ServiceResponse<School>> DeleteSchool(int id);
        Task<ServiceResponse<List<School>>> GetAllSchool();
        Task<ServiceResponse<School>> SchoolEdit(School School);
        Task<ServiceResponse<List<School>>> GetSchoolsByCityName(string CityName);
        Task<ServiceResponse<List<School>>> GetSchoolsByDistrictName(string DistrictName);
        Task<ServiceResponse<School>> GetSchoolByName(string SchoolName);

    }
}