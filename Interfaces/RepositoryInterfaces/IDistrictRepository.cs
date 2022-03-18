namespace JobForStudents
{

    public interface IDistrictRepository
    {
        Task<District> CreateDistrict(District District);
        Task<District> DeleteDistrict(string name);
        Task<List<District>> GetAllDistrict();
        Task<District> FindDistrictByName(string DistrictName);
        Task<District> DistrictEdit(District District);



    }
}