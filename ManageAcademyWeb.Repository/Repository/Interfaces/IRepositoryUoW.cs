using Microsoft.EntityFrameworkCore.Storage;

namespace ManageAcademyWeb.Repository.Repository.Interfaces
{
    public interface IRepositoryUoW
    {
        Task SaveAsync();
        void Commit();
        IDbContextTransaction BeginTransaction();
    }
}