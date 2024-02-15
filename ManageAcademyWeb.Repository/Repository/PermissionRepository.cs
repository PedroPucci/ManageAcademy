using ManageAcademyWeb.Domain.Entity;
using ManageAcademyWeb.Repository.Repository.Interfaces;

namespace ManageAcademyWeb.Repository.Repository
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly DataBaseContext _context;

        public PermissionRepository(DataBaseContext context)
        {
            _context = context;
        }

        public Task<PermissionEntity> AddPermissionAsync(PermissionEntity permissionEntity)
        {
            throw new NotImplementedException();
        }

        public Task<List<PermissionEntity>> GetAllPermissionAsync()
        {
            throw new NotImplementedException();
        }

        public PermissionEntity UpdatePermission(PermissionEntity permissionEntity)
        {
            throw new NotImplementedException();
        }
    }
}