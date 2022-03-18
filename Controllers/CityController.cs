using Microsoft.AspNetCore.Mvc;




namespace JobForStudents
{
    [ApiController]
    [Route("[controller]")]
    public class CityController : ControllerBase
    {
        private readonly ICityService _ICityService;
        private ResponseGeneratorHelper ResponseGeneratorHelper;

        public CityController(ICityService ICityService)
        {
            _ICityService = ICityService;
            ResponseGeneratorHelper = new ResponseGeneratorHelper();
        }


        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<City>>>> GetAllCity()
        {
            return await _ICityService.GetAllCity();
        }

        [HttpPost("CreateCity")]
        public async Task<ActionResult<ServiceResponse<City>>> CreateCity(City City)
        {
            return await _ICityService.CreateCity(City);

        }

        [HttpDelete("{name}")]
        public async Task<ActionResult<ServiceResponse<City>>> DeleteCity(string name)
        {
            return await _ICityService.DeleteCity(name);

        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<City>>> CityEdit(City City)
        {
            return await _ICityService.CitytEdit(City);
        }

    }

}


