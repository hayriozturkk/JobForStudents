using Microsoft.AspNetCore.Mvc;




namespace JobForStudents
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _ICompanyService;
        private ResponseGeneratorHelper ResponseGeneratorHelper;

        public CompanyController(ICompanyService ICompanyService)
        {
            _ICompanyService = ICompanyService;
            ResponseGeneratorHelper = new ResponseGeneratorHelper();
        }


        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Company>>>> GetAllCompany()
        {
            return await _ICompanyService.GetAllCompany();
        }

        //https://localhost:7049/Company/GetCompanyByName?Name=Öztürk Mühendislik
        [HttpGet("GetCompanyByName")]
        public async Task<ActionResult<ServiceResponse<Company>>> GetCompanyByName(string Name)
        {
            return await _ICompanyService.GetCompanyByName(Name);
        }

        //https://localhost:7049/Company/GetCompanyByCategory?Category=Elektrik Mühendisliği
        [HttpGet("GetCompanyByCategory")]
        public async Task<ActionResult<ServiceResponse<List<Company>>>> GetCompanyByCategory(string Category)
        {
            return await _ICompanyService.GetCompanyByCategory(Category);
        }

        //https://localhost:7049/Company/GetCompanyByCity?CityName=Ankara
        [HttpGet("GetCompanyByCity")]
        public async Task<ActionResult<ServiceResponse<List<Company>>>> GetCompanyByCity(string CityName)
        {
            return await _ICompanyService.GetCompanyByCity(CityName);
        }

        //https://localhost:7049/Company/GetCompanyByDistrict?DistrictName=Mamak
        [HttpGet("GetCompanyByDistrict")]
        public async Task<ActionResult<ServiceResponse<List<Company>>>> GetCompanyByDistrict(string DistrictName)
        {
            return await _ICompanyService.GetCompanyByDistrict(DistrictName);
        }

        [HttpPost("CreateCompany")]
        public async Task<ActionResult<ServiceResponse<Company>>> CreateCompany(Company Company)
        {
            return await _ICompanyService.CreateCompany(Company);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<Company>>> DeleteCompany(int id)
        {
            return await _ICompanyService.DeleteCompany(id);

        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<Company>>> CompanyEdit(Company Company)
        {
            return await _ICompanyService.CompanyEdit(Company);
        }

    }

}


