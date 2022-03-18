namespace JobForStudents
{

    public interface ICityRepository
    {
        Task<City> CreateCity(City City);
        Task<City> DeleteCity(string name);
        Task<List<City>> GetAllCity();
        Task<City> FindCityByName(string CityName);
        Task<City> CityEdit(City City);



    }
}