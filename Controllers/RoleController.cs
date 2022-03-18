using Microsoft.AspNetCore.Mvc;




namespace JobForStudents
{
    [ApiController]
    [Route("[controller]")]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _IRoleService;
        private ResponseGeneratorHelper ResponseGeneratorHelper;

        public RoleController(IRoleService IRoleService)
        {
            _IRoleService = IRoleService;
            ResponseGeneratorHelper = new ResponseGeneratorHelper();
        }


        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Role>>>> GetAllRole()
        {
            return await _IRoleService.GetAllRole();
        }

        [HttpPost("CreateRole")]
        public async Task<ActionResult<ServiceResponse<Role>>> CreateRole(Role Role)
        {
            return await _IRoleService.CreateRole(Role);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<Role>>> DeleteRole(int id)
        {
            return await _IRoleService.DeleteRole(id);

        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<Role>>> RoleEdit(Role Role)
        {
            return await _IRoleService.RoleEdit(Role);
        }

    }

}


