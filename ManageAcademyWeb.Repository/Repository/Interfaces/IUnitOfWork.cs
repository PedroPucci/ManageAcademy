namespace ManageAcademyWeb.Repository.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        void Rollback();
        IRepository<T> GetRepository<T>() where T : class;
    }
}