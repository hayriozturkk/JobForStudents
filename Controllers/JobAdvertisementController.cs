using Microsoft.AspNetCore.Mvc;




namespace JobForStudents
{
    [ApiController]
    [Route("[controller]")]
    public class JobAdvertisementController : ControllerBase
    {
        private readonly IJobAdvertisementService _IJobAdvertisementService;
        private ResponseGeneratorHelper ResponseGeneratorHelper;

        public JobAdvertisementController(IJobAdvertisementService IJobAdvertisementService)
        {
            _IJobAdvertisementService = IJobAdvertisementService;
            ResponseGeneratorHelper = new ResponseGeneratorHelper();
        }


        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<JobAdvertisement>>>> GetAllJobAdvertisement()
        {
            return await _IJobAdvertisementService.GetAllJobAdvertisement();
        }


        ///https://localhost:7049/JobAdvertisement/GetJobAdvertisementBySalary?MaxSalary=12000&MinSalary=0
        [HttpGet("GetJobAdvertisementBySalary")]
        public async Task<ActionResult<ServiceResponse<List<JobAdvertisement>>>> GetJobAdvertisementBySalary([FromQuery] int MaxSalary,[FromQuery] int MinSalary)
        {
            return await _IJobAdvertisementService.GetJobAdvertisementBySalary(MaxSalary, MinSalary);
        }


        //https://localhost:7049/JobAdvertisement/GetJobAdvertisementByCategory?Category=Elektrik+Mühendisliği
        [HttpGet("GetJobAdvertisementByCategory")]
        public async Task<ActionResult<ServiceResponse<List<JobAdvertisement>>>> GetJobAdvertisementByCategory([FromQuery] string Category)
        {
            return await _IJobAdvertisementService.GetJobAdvertisementByCategory(Category);
        }

        ///https://localhost:7049/JobAdvertisement/GetJobAdvertisementByTitle?Title=Yazılım+Mühendisi
        [HttpGet("GetJobAdvertisementByTitle")]
        public async Task<ActionResult<ServiceResponse<List<JobAdvertisement>>>> GetJobAdvertisementByTitle([FromQuery] string Title)
        {
            return await _IJobAdvertisementService.GetJobAdvertisementByTitle(Title);
        }


        //https://localhost:7049/JobAdvertisement/GetJobAdvertisementByCity?City=İstanbul
        [HttpGet("GetJobAdvertisementByCity")]
        public async Task<ActionResult<ServiceResponse<List<JobAdvertisement>>>> GetJobAdvertisementByCity([FromQuery] string City)
        {
            return await _IJobAdvertisementService.GetJobAdvertisementByCity(City);
        }

        //https://localhost:7049/JobAdvertisement/GetJobAdvertisementByDistrict?District=Mamak
        [HttpGet("GetJobAdvertisementByDistrict")]
        public async Task<ActionResult<ServiceResponse<List<JobAdvertisement>>>> GetJobAdvertisementByDistrict([FromQuery] string District)
        {
            return await _IJobAdvertisementService.GetJobAdvertisementByDistrict(District);
        }

        ///https://localhost:7049/JobAdvertisement/GetJobAdvertisementByName?Name=java+Developer
        [HttpGet("GetJobAdvertisementByName")]
        public async Task<ActionResult<ServiceResponse<List<JobAdvertisement>>>> GetJobAdvertisementByName([FromQuery] string Name)
        {
            return await _IJobAdvertisementService.GetJobAdvertisementByName(Name);
        }

        //https://localhost:7049/JobAdvertisement/GetJobAdvertisementByWorkingTime?WorkingTime=1
        [HttpGet("GetJobAdvertisementByWorkingTime")]
        public async Task<ActionResult<ServiceResponse<List<JobAdvertisement>>>> GetJobAdvertisementByWorkingTime([FromQuery] int WorkingTime)
        {
            return await _IJobAdvertisementService.GetJobAdvertisementByWorkingTime(WorkingTime);
        }

        //https://localhost:7049/JobAdvertisement/GetJobAdvertisementByCompanyName?CompanyName=SahaBt+Yazilim
        [HttpGet("GetJobAdvertisementByCompanyName")]
        public async Task<ActionResult<ServiceResponse<List<JobAdvertisement>>>> GetJobAdvertisementByCompanyName([FromQuery] string CompanyName)
        {
            return await _IJobAdvertisementService.GetJobAdvertisementByCompanyName(CompanyName);
        }


        //https://localhost:7049/JobAdvertisement/JobAdvertisementByCityMinSalaryTitle?City=Ankara&MinSalary=10000&Title=Yazılım+Mühendisi
        [HttpGet("JobAdvertisementByCityMinSalaryTitle")]
        public async Task<ActionResult<ServiceResponse<List<JobAdvertisement>>>> JobAdvertisementByCityMinSalaryTitle([FromQuery] string City,int MinSalary,string Title)
        {
            return await _IJobAdvertisementService.JobAdvertisementByCityMinSalaryTitle(City,MinSalary,Title);
        }

        

        [HttpPost("CreateJobAdvertisement")]
        public async Task<ActionResult<ServiceResponse<JobAdvertisement>>> CreateJobAdvertisement(JobAdvertisement JobAdvertisement)
        {
            return await _IJobAdvertisementService.CreateJobAdvertisement(JobAdvertisement);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<JobAdvertisement>>> DeleteJobAdvertisement(int id)
        {
            return await _IJobAdvertisementService.DeleteJobAdvertisement(id);

        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<JobAdvertisement>>> JobAdvertisementEdit(JobAdvertisement JobAdvertisement)
        {
            return await _IJobAdvertisementService.JobAdvertisementEdit(JobAdvertisement);
        }

    }

}


