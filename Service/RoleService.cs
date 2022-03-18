
namespace JobForStudents
{
    public class RoleService : IRoleService
    {
        private RoleRepository _RoleRepository;
        public RoleService()
        {
            _RoleRepository = new RoleRepository();
        }

        public async Task<ServiceResponse<Role>> CreateRole(Role Role)
        {
            ServiceResponse<Role> response = new ServiceResponse<Role>();
            var FromRepositoryRole= await _RoleRepository.FindRoleById(Role.Id);
            if (FromRepositoryRole== null)
            {
                await _RoleRepository.CreateRole(Role);
                response.ResponseCode= ResponseCodeEnum.CreateRoleOperationSuccess;
                response.Data=Role;
                return response;
            }
            else
            {
                response.ResponseCode= ResponseCodeEnum.CreateRoleOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<Role>> DeleteRole(int id)
        {
            ServiceResponse<Role> response = new ServiceResponse<Role>();
            var FromRepositoryRole = await _RoleRepository.FindRoleById(id);
            if (FromRepositoryRole != null)
            {
                await _RoleRepository.DeleteRole(id);
                response.ResponseCode = ResponseCodeEnum.DeleteRoleOperationSuccess;
                response.Data=FromRepositoryRole;
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.DeleteRoleOperationFail;
                response.Data=null;
                return response;
            }
        }

        public async Task<ServiceResponse<List<Role>>> GetAllRole()
        {
            ServiceResponse<List<Role>> response = new ServiceResponse<List<Role>>();
            List<Role> IncomingFromRepository = await _RoleRepository.GetAllRole();
            if(IncomingFromRepository.Count != 0 )
            {
                response.Data = await _RoleRepository.GetAllRole();
                response.ResponseCode = ResponseCodeEnum.GetAllRoleOperationSuccess;
                return response;
            }
            else
            {
                response.Data = null;
                response.ResponseCode = ResponseCodeEnum.GetAllRoleOperationFail;
                return response;
            }
        }

        public async Task<ServiceResponse<Role>> RoleEdit(Role Role)
        {
            ServiceResponse<Role> response = new ServiceResponse<Role>();
            var editedRole = _RoleRepository.RoleEdit(Role);

            if (editedRole != null)
            {
                
                response.ResponseCode = ResponseCodeEnum.Success;
                response.Data= await editedRole; 
                return response;
            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.RoleEditOperationFail;
                return response;
            }
        }

      
    }


}



