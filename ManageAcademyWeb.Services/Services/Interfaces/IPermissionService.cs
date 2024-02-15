using ManageAcademyWeb.Domain.Dto;
using ManageAcademyWeb.Domain.Entity;

namespace ManageAcademyWeb.Services.Services.Interfaces
{
    public interface IPermissionService
    {
        Task<GenericResult<PermissionEntity>> AddPermission(PermissionDto permissionDto);
        Task<PermissionEntity> UpdatePermission(PermissionDto permissionDto);
        Task<List<PermissionEntity>> GetAllPermissions();
    }
}