using Microsoft.AspNetCore.Mvc;




namespace JobForStudents
{
    [ApiController]
    [Route("[controller]")]
    public class SchoolController : ControllerBase
    {
        private readonly ISchoolService _ISchoolService;
        private ResponseGeneratorHelper ResponseGeneratorHelper;

        public SchoolController(ISchoolService ISchoolService)
        {
            _ISchoolService = ISchoolService;
            ResponseGeneratorHelper = new ResponseGeneratorHelper();
        }


        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<School>>>> GetAllSchool()
        {
            return await _ISchoolService.GetAllSchool();
        }

        //https://localhost:7049/School/GetSchoolByName?SchoolName=Zonguldak+Bülent+Ecevit+Üniversitesi
        [HttpGet("GetSchoolByName")]
        public async Task<ActionResult<ServiceResponse<School>>> GetSchoolByName(string SchoolName)
        {
            return await _ISchoolService.GetSchoolByName(SchoolName);
        }


        //https://localhost:7049/School/GetSchoolsByCityName?CityName=Ankara
        [HttpGet("GetSchoolsByCityName")]
        public async Task<ActionResult<ServiceResponse<List<School>>>> GetSchoolsByCityName(string CityName)
        {
            return await _ISchoolService.GetSchoolsByCityName(CityName);
        }

        //https://localhost:7049/School/GetSchoolsByDistrictName?DistrictName=Mamak
        [HttpGet("GetSchoolsByDistrictName")]
        public async Task<ActionResult<ServiceResponse<List<School>>>> GetSchoolsByDistrictName(string DistrictName)
        {
            return await _ISchoolService.GetSchoolsByDistrictName(DistrictName);
        }

        [HttpPost("CreateSchool")]
        public async Task<ActionResult<ServiceResponse<School>>> CreateSchool(School School)
        {
            return await _ISchoolService.CreateSchool(School);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<School>>> DeleteSchool(int id)
        {
            return await _ISchoolService.DeleteSchool(id);

        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<School>>> SchoolEdit(School School)
        {
            return await _ISchoolService.SchoolEdit(School);
        }

    }

}


