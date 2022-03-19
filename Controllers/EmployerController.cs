using Microsoft.AspNetCore.Mvc;




namespace JobForStudents
{
    [ApiController]
    [Route("[controller]")]
    public class EmployerController : ControllerBase
    {
        private readonly IEmployerService _IEmployerService;
        private ResponseGeneratorHelper ResponseGeneratorHelper;

        public EmployerController(IEmployerService IEmployerService)
        {
            _IEmployerService = IEmployerService;
            ResponseGeneratorHelper = new ResponseGeneratorHelper();
        }


        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Employer>>>> GetAllEmployer()
        {
            return await _IEmployerService.GetAllEmployer();
        }

        //https://localhost:7049/Employer/GetEmployerByGender?GenderId=2
        [HttpGet("GetEmployerByGender")]
        public async Task<ActionResult<ServiceResponse<List<Employer>>>> GetEmployerByGender([FromQuery] int GenderId)
        {
            return await _IEmployerService.GetEmployerByGender(GenderId);
        }


        //https://localhost:7049/Employer/GetEmployersByBirthDate?MaxBirthDate=2023-12-30&MinBirthDate=2022-12-30
        [HttpGet("GetEmployersByBirthDate")]
        public async Task<ActionResult<ServiceResponse<List<Employer>>>> GetEmployersByBirthDate([FromQuery] DateTime MaxBirthDate, DateTime MinBirthDate)
        {
            return await _IEmployerService.GetEmployersByBirthDate(MaxBirthDate,MinBirthDate);
        }

        //https://localhost:7049/Employer/GetEmployerCompany?CompanyName=SahaBt+Yazilim
        [HttpGet("GetEmployerCompany")]
        public async Task<ActionResult<ServiceResponse<List<Employer>>>> GetEmployerCompany([FromQuery] string CompanyName)
        {
            return await _IEmployerService.GetEmployerCompany(CompanyName);
        }

        //https://localhost:7049/Employer/GetEmployerByName?Name=Employer1
         [HttpGet("GetEmployerByName")]
        public async Task<ActionResult<ServiceResponse<Employer>>> GetEmployerByName([FromQuery] string Name)
        {
            return await _IEmployerService.GetEmployerByName(Name);
        }

        [HttpPost("CreateEmployer")]
        public async Task<ActionResult<ServiceResponse<Employer>>> CreateEmployer(Employer Employer)
        {
            return await _IEmployerService.CreateEmployer(Employer);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<Employer>>> DeleteEmployer(int id)
        {
            return await _IEmployerService.DeleteEmployer(id);

        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<Employer>>> EmployerEdit(Employer Employer)
        {
            return await _IEmployerService.EmployerEdit(Employer);
        }

    }

}


