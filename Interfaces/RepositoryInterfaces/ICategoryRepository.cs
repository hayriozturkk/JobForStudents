namespace JobForStudents
{

    public interface ICategoryRepository
    {
        Task<Category> CreateCategory(Category Category);
        Task<Category> DeleteCategory(int id);
        Task<List<Category>> GetAllCategory();
        Task<Category> FindCategoryById(int id);
        Task<Category> CategoryEdit(Category Category);
        Task<Category> GetCategoryByName(string CategoryName);



    }
}