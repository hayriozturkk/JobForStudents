namespace JobForStudents
{

    public interface IRoleService
    {
        Task<ServiceResponse<Role>> CreateRole(Role Role);
        Task<ServiceResponse<Role>> DeleteRole(int id);
        Task<ServiceResponse<List<Role>>> GetAllRole();
        Task<ServiceResponse<Role>> RoleEdit(Role Role);




    }
}