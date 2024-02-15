using ManageAcademyWeb.Repository.Repository.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;

namespace ManageAcademyWeb.Repository.Repository
{
    public class RepositoryUoW : IRepositoryUoW
    {
        private readonly DataBaseContext _context;
        private bool _disposed = false;
        private IPermissionRepository? _permissionRepository = null;

        public RepositoryUoW(DataBaseContext context)
        {
            _context = context;
        }

        public IPermissionRepository PermissionRepository
        {
            get
            {
                if (_permissionRepository == null)
                {
                    _permissionRepository = new PermissionRepository(_context);
                }
                return _permissionRepository;
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public IDbContextTransaction BeginTransaction()
        {
            return _context.Database.BeginTransaction();
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                _context.Dispose();
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}