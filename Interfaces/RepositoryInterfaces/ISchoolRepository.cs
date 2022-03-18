namespace JobForStudents
{

    public interface ISchoolRepository
    {
        Task<School> CreateSchool(School School);
        Task<School> DeleteSchool(int id);
        Task<List<School>> GetAllSchool();
        Task<School> FindSchoolById(int id);
        Task<School> SchoolEdit(School School);
        Task<School> GetSchoolByName(String SchoolName);
        Task<List<School>> GetSchoolsByCityName(string CityName);
        Task<List<School>> GetSchoolsByDistrictName(string DistrictName);



    }
}