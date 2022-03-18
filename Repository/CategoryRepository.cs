using Microsoft.EntityFrameworkCore;

namespace JobForStudents
{
    public class CategoryRepository : ICategoryRepository
    {
        DBContext _DbContext;

        public CategoryRepository()
        {
            _DbContext = new DBContext();
        }

        public async Task<Category> CreateCategory(Category Category)
        {
            await _DbContext.Set<Category>().AddAsync(Category);
            await _DbContext.SaveChangesAsync();
            return Category;
        }

        public async Task<Category> DeleteCategory(int id)
        {
            var deletedCategory = await _DbContext.Set<Category>().FirstOrDefaultAsync(x => x.Id == id);
            _DbContext.Set<Category>().Remove(deletedCategory);
            _DbContext.SaveChangesAsync();
            return deletedCategory;
        }

        public async Task<Category> FindCategoryById(int id)
        {
            return await _DbContext.Set<Category>().FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<Category>> GetAllCategory()
        {
            return await _DbContext.Set<Category>().ToListAsync();
        }
        public async Task<Category> CategoryEdit(Category Category)
        {
            _DbContext.Set<Category>().Update(Category);
            _DbContext.SaveChangesAsync();
            return Category;
        }

        public async Task<Category> GetCategoryByName(string CategoryName)
        {
            return await _DbContext.Set<Category>().FirstOrDefaultAsync(c => c.Name == CategoryName);
        }
    }
}


