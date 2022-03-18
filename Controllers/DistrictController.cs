using Microsoft.AspNetCore.Mvc;




namespace JobForStudents
{
    [ApiController]
    [Route("[controller]")]
    public class DistrictController : ControllerBase
    {
        private readonly IDistrictService _IDistrictService;
        private ResponseGeneratorHelper ResponseGeneratorHelper;

        public DistrictController(IDistrictService IDistrictService)
        {
            _IDistrictService = IDistrictService;
            ResponseGeneratorHelper = new ResponseGeneratorHelper();
        }


        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<District>>>> GetAllDistricts()
        {
            return await _IDistrictService.GetAllDistrict();
        }

        [HttpPost("CreateDistrict")]
        public async Task<ActionResult<ServiceResponse<District>>> CreateDistrict(District District)
        {
            return await _IDistrictService.CreateDistrict(District);

        }

        [HttpDelete("{name}")]
        public async Task<ActionResult<ServiceResponse<District>>> DeleteDistrict(string name)
        {
            return await _IDistrictService.DeleteDistrict(name);

        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<District>>> DistrictEdit(District District)
        {
            return await _IDistrictService.DistrictEdit(District);
        }

    }

}


