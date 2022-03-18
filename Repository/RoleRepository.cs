using Microsoft.EntityFrameworkCore;

namespace JobForStudents
{
    public class RoleRepository : IRoleRepository
    {
        DBContext _DbContext;

        public RoleRepository()
        {
            _DbContext = new DBContext();
        }

        public async Task<Role> CreateRole(Role Role)
        {
            await _DbContext.Set<Role>().AddAsync(Role);
            await _DbContext.SaveChangesAsync();
            return Role;
        }

        public async Task<Role> DeleteRole(int id)
        {
            var deletedRole = await _DbContext.Set<Role>().FirstOrDefaultAsync(x => x.Id == id);
            _DbContext.Set<Role>().Remove(deletedRole);
            _DbContext.SaveChangesAsync();
            return deletedRole;
        }

        public async Task<Role> FindRoleById(int id)
        {
            return await _DbContext.Set<Role>().FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<Role>> GetAllRole()
        {
            return await _DbContext.Set<Role>().ToListAsync();
        }
        public async Task<Role> RoleEdit(Role Role)
        {
            _DbContext.Set<Role>().Update(Role);
            _DbContext.SaveChangesAsync();
            return Role;
        }
    }



}


