using ManageAcademyWeb.Domain.Entity;
using ManageAcademyWeb.Repository.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Security;

namespace ManageAcademyWeb.Repository.Repository
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly DataBaseContext _context;

        public PermissionRepository(DataBaseContext context)
        {
            _context = context;
        }

        public async Task<PermissionEntity> AddPermissionAsync(PermissionEntity permissionEntity)
        {
            var result = await _context.PermissionEntity.AddAsync(permissionEntity);
            return result.Entity;
        }

        public async Task<List<PermissionEntity>> GetAllPermissionAsync()
        {
            return await _context.PermissionEntity.OrderBy(permission => permission.Name)
                .Select(permission => new PermissionEntity
            {
                Name = permission.Name,
                Status = permission.Status,
                Description = permission.Description,
                Type = permission.Type,
            }).ToListAsync();
        }

        public async Task<PermissionEntity> GetPermissionByNameAsync(string name)
        {
            var permission = await _context.PermissionEntity.FirstOrDefaultAsync(permission => permission.Name == name);
            return permission ?? new PermissionEntity();
        }

        public PermissionEntity UpdatePermission(PermissionEntity permissionEntity)
        {
            var response = _context.PermissionEntity.Update(permissionEntity);
            return response.Entity;
        }

        public async Task<PermissionEntity> DeletePermissionAsync(string name)
        {
            var permissionToDelete = await _context.PermissionEntity.FirstOrDefaultAsync(permission => permission.Name == name);

            if (permissionToDelete != null)
            {
                _context.PermissionEntity.Remove(permissionToDelete);
                await _context.SaveChangesAsync();
            }

            return permissionToDelete ?? new PermissionEntity();
        }
    }
}