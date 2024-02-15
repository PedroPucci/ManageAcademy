using ManageAcademyWeb.Domain.Entity;

namespace ManageAcademyWeb.Repository.Repository.Interfaces
{
    public interface IPermissionRepository
    {
        Task<PermissionEntity> AddPermissionAsync(PermissionEntity permissionEntity);
        PermissionEntity UpdatePermission(PermissionEntity permissionEntity);
        Task<List<PermissionEntity>> GetAllPermissionAsync();
    }
}