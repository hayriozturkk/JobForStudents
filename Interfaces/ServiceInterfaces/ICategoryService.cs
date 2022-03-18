namespace JobForStudents
{

    public interface ICategoryService
    {
        Task<ServiceResponse<Category>> CreateCategory(Category Category);
        Task<ServiceResponse<Category>> DeleteCategory(int id);
        Task<ServiceResponse<List<Category>>> GetAllCategory();
        Task<ServiceResponse<Category>> CategoryEdit(Category Category);
        Task<ServiceResponse<Category>> GetCategoryByName(string CategoryName);





    }
}