using Microsoft.EntityFrameworkCore.Storage;

namespace ManageAcademyWeb.Repository.Repository.Interfaces
{
    public interface IRepositoryUoW
    {
        IPermissionRepository PermissionRepository { get; }

        Task SaveAsync();
        void Commit();
        IDbContextTransaction BeginTransaction();
    }
}