
namespace JobForStudents
{
    public class CategoryService : ICategoryService
    {
        private CategoryRepository _CategoryRepository;
        public CategoryService()
        {
            _CategoryRepository = new CategoryRepository();
        }

        public async Task<ServiceResponse<Category>> CreateCategory(Category Category)
        {
            ServiceResponse<Category> response = new ServiceResponse<Category>();
            var IncomingCategory= await _CategoryRepository.FindCategoryById(Category.Id);
            if (IncomingCategory== null)
            {
                await _CategoryRepository.CreateCategory(Category);
                response.ResponseCode= ResponseCodeEnum.CreateCategoryOperationSuccess;
                response.Data=Category;
                return response;
            }
            else
            {
                response.ResponseCode= ResponseCodeEnum.CreateCategoryOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<Category>> DeleteCategory(int id)
        {
            ServiceResponse<Category> response = new ServiceResponse<Category>();
            var IncomingCategory = await _CategoryRepository.FindCategoryById(id);
            if (IncomingCategory != null)
            {
                await _CategoryRepository.DeleteCategory(id);
                response.ResponseCode = ResponseCodeEnum.DeleteCategoryOperationSuccess;
                response.Data=IncomingCategory;
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.DeleteCategoryOperationFail;
                response.Data=null;
                return response;
            }
        }

        public async Task<ServiceResponse<List<Category>>> GetAllCategory()
        {
            ServiceResponse<List<Category>> response = new ServiceResponse<List<Category>>();
            try
            {
                response.Data = await _CategoryRepository.GetAllCategory();
                response.ResponseCode = ResponseCodeEnum.GetAllCategoryOperationSuccess;
                return response;
            }
            catch (Exception e)
            {
                response.Data = null;
                response.ResponseCode = ResponseCodeEnum.GetAllCategoryOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<Category>> CategoryEdit(Category Category)
        {
            ServiceResponse<Category> response = new ServiceResponse<Category>();
            var editedCategory = _CategoryRepository.CategoryEdit(Category);

            if (editedCategory != null)
            {
                
                response.ResponseCode = ResponseCodeEnum.Success;
                response.Data= await editedCategory; 
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.CategoryEditOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<Category>> GetCategoryByName(string categoryName)
        {
            ServiceResponse<Category> response = new ServiceResponse<Category>();
            var GetCategoryByName = await _CategoryRepository.GetCategoryByName(categoryName);
            if (GetCategoryByName != null)
            {
                response.ResponseCode = ResponseCodeEnum.Success;
                response.Data=  GetCategoryByName; 
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.GetCategoryByNameOperationFail;
                return response;
            }
        }

      
    }


}



