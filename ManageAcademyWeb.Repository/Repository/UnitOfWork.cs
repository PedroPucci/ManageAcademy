using ManageAcademyWeb.Repository.Repository.Interfaces;
using Microsoft.Extensions.Logging;

namespace ManageAcademyWeb.Repository.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataBaseContext _context;
        private readonly ILogger _logger;
        private Dictionary<Type, object> _repositories;

        public UnitOfWork(DataBaseContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
            _repositories = new Dictionary<Type, object>();
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            // Rollback changes if needed
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            if (_repositories.ContainsKey(typeof(T)))
            {
                return (IRepository<T>)_repositories[typeof(T)];
            }

            var repository = new Repository<T>(_context, _logger);
            _repositories.Add(typeof(T), repository);
            return repository;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}