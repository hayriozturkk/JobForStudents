using Microsoft.AspNetCore.Mvc;




namespace JobForStudents
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _ICategoryService;
        private ResponseGeneratorHelper ResponseGeneratorHelper;

        public CategoryController(ICategoryService ICategoryService)
        {
            _ICategoryService = ICategoryService;
            ResponseGeneratorHelper = new ResponseGeneratorHelper();
        }


        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> GetAllCategory()
        {
            return await _ICategoryService.GetAllCategory();
        }

        //https://localhost:7049/Category/GetCategoryByName?CategoryName=Bilgisayar Mühendisliği
        [HttpGet("GetCategoryByName")]
        public async Task<ActionResult<ServiceResponse<Category>>> GetCategoryByName(string CategoryName)
        {
            return await _ICategoryService.GetCategoryByName(CategoryName);
        }
        

        [HttpPost("CreateCategory")]
        public async Task<ActionResult<ServiceResponse<Category>>> CreateCategory(Category Category)
        {
            return await _ICategoryService.CreateCategory(Category);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<Category>>> DeleteCategory(int id)
        {
            return await _ICategoryService.DeleteCategory(id);

        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<Category>>> CategoryEdit(Category Category)
        {
            return await _ICategoryService.CategoryEdit(Category);
        }

    }

}


