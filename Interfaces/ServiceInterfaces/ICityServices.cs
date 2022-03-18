namespace JobForStudents
{

    public interface ICityService
    {
        Task<ServiceResponse<City>> CreateCity(City City);
        Task<ServiceResponse<City>> DeleteCity(string name);
        Task<ServiceResponse<List<City>>> GetAllCity();
        Task<ServiceResponse<City>> CitytEdit(City City);




    }
}