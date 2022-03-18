using Microsoft.AspNetCore.Mvc;




namespace JobForStudents
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _IStudentService;
        private ResponseGeneratorHelper ResponseGeneratorHelper;

        public StudentController(IStudentService IStudentService)
        {
            _IStudentService = IStudentService;
            ResponseGeneratorHelper = new ResponseGeneratorHelper();
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Student>>>> GetAllStudent()
        {
            return await _IStudentService.GetAllStudent();
        }

        [HttpGet("GetStudentsBySchool")]
        public async Task<ActionResult<ServiceResponse<List<Student>>>> GetStudentsBySchool([FromQuery] string SchoolName)
        {
            return await _IStudentService.GetStudentsBySchool(SchoolName);
        }

        //https://localhost:7049/Student/GetStudentsByDistrict?DistrictName=Mamak
        [HttpGet("GetStudentsByDistrict")]
        public async Task<ActionResult<ServiceResponse<List<Student>>>> GetStudentsByDistrict([FromQuery] string DistrictName)
        {
            return await _IStudentService.GetStudentsByDistrict(DistrictName);
        }


        //https://localhost:7049/Student/GetStudentsByCity?CityName=Ankara
        [HttpGet("GetStudentsByCity")]
        public async Task<ActionResult<ServiceResponse<List<Student>>>> GetStudentsByCity([FromQuery] string CityName)
        {
            return await _IStudentService.GetStudentsByCity(CityName);
        }

        //https://localhost:7049/Student/FindStudentByName?Name=Hayri222
        [HttpGet("FindStudentByName")]
        public async Task<ActionResult<ServiceResponse<Student>>> FindStudentByName([FromQuery] string Name)
        {
            return await _IStudentService.FindStudentByName(Name);
        }

        //https://localhost:7049/Student/GetStudentsByEducationTour?EducationTourId=1
        [HttpGet("GetStudentsByEducationTour")]
        public async Task<ActionResult<ServiceResponse<List<Student>>>> GetStudentsByEducationTour([FromQuery] int EducationTourId)
        {
            return await _IStudentService.GetStudentsByEducationTour(EducationTourId);
        }

        //https://localhost:7049/Student/GetStudentsByGender?GenderId=1
        [HttpGet("GetStudentsByGender")]
        public async Task<ActionResult<ServiceResponse<List<Student>>>> GetStudentsByGender([FromQuery] int GenderId)
        {
            return await _IStudentService.GetStudentsByGender(GenderId);
        }

        //https://localhost:7049/Student/GetStudentsByEducation?EducationId=1
        [HttpGet("GetStudentsByEducation")]
        public async Task<ActionResult<ServiceResponse<List<Student>>>> GetStudentsByEducation([FromQuery] int EducationId)
        {
            return await _IStudentService.GetStudentsByEducation(EducationId);
        }


        //https://localhost:7049/Student/GetStudentsByBirthDate?MaxBirthDate=2023-12-30&MinBirthDate=2020-12-30
        [HttpGet("GetStudentsByBirthDate")]
        public async Task<ActionResult<ServiceResponse<List<Student>>>> GetStudentsByBirthDate([FromQuery] DateTime MaxBirthDate, DateTime MinBirthDate)
        {
            return await _IStudentService.GetStudentsByBirthDate(MaxBirthDate, MinBirthDate);
        }

        [HttpPost("CreateStudent")]
        public async Task<ActionResult<ServiceResponse<Student>>> CreateStudent(Student Student)
        {
            return await _IStudentService.CreateStudent(Student);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<Student>>> DeleteStudent(int id)
        {
            return await _IStudentService.DeleteStudent(id);

        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<Student>>> StudentEdit(Student Student)
        {
            return await _IStudentService.StudentEdit(Student);
        }

    }

}


