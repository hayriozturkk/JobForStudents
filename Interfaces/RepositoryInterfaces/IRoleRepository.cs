namespace JobForStudents
{

    public interface IRoleRepository
    {
        Task<Role> CreateRole(Role Role);
        Task<Role> DeleteRole(int id);
        Task<List<Role>> GetAllRole();
        Task<Role> FindRoleById(int id);
        Task<Role> RoleEdit(Role Role);



    }
}