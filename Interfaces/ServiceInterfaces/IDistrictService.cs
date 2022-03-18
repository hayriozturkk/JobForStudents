namespace JobForStudents
{

    public interface IDistrictService
    {

        Task<ServiceResponse<District>> CreateDistrict(District District);
        Task<ServiceResponse<District>> DeleteDistrict(string name);
        Task<ServiceResponse<List<District>>> GetAllDistrict();
        Task<ServiceResponse<District>> DistrictEdit(District District);



    }
}