using Microsoft.AspNetCore.Mvc;




namespace JobForStudents
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _IAddressService;
        private ResponseGeneratorHelper ResponseGeneratorHelper;

        public AddressController(IAddressService IAddressService)
        {
            _IAddressService = IAddressService;
            ResponseGeneratorHelper = new ResponseGeneratorHelper();
        }


        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Address>>>> GetAllAddress()
        {
            return await _IAddressService.GetAllAddress();
        }

        //https://localhost:7049/Address/GetAllAddressByDistrictName?CityName=Ankara 
        [HttpGet("GetAllAddressByCityName")]
        public async Task<ActionResult<ServiceResponse<List<Address>>>> GetAllAddressByCityName(string CityName)
        {
            return await _IAddressService.GetAllAddressByCityName(CityName);
        }

        //https://localhost:7049/Address/GetAllAddressByDistrictName?DistrictName=Mamak
        [HttpGet("GetAllAddressByDistrictName")]
        public async Task<ActionResult<ServiceResponse<List<Address>>>> GetAllAddressByDistrictName(string DistrictName)
        {
            return await _IAddressService.GetAllAddressByDistrictName(DistrictName);
        }

        //https://localhost:7049/Address/GetAllCity
        [HttpGet("GetAllCity")]
        public async Task<ActionResult<ServiceResponse<List<City>>>> GetAllCity()
        {
            return await _IAddressService.GetAllCity();
        }

        //https://localhost:7049/Address/GetAllDistrict?CityName=Ankara
        [HttpGet("GetAllDistrict")]
        public async Task<ActionResult<ServiceResponse<List<District>>>> GetAllDistrictByCityName(string CityName)
        {
            return await _IAddressService.GetAllDistrictByCityName(CityName);
        }


        [HttpPost("CreateAddress")]
        public async Task<ActionResult<ServiceResponse<Address>>> CreateAddress(Address Address)
        {
            return await _IAddressService.CreateAddress(Address);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<Address>>> DeleteAddress(int id)
        {
            return await _IAddressService.DeleteAddress(id);

        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<Address>>> AddressEdit(Address Address)
        {
            return await _IAddressService.AddressEdit(Address);
        }

    }

}


