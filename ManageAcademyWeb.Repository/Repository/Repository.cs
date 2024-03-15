using System.Linq.Expressions;
using ManageAcademyWeb.Repository.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ManageAcademyWeb.Repository.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DataBaseContext _context;
        private readonly DbSet<T> _dbSet;
        private readonly ILogger _logger;

        public Repository(DataBaseContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
            _dbSet = context.Set<T>();
        }

        public T Get(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return _dbSet.FirstOrDefault(predicate);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error getting entity!");
                throw new ArgumentNullException();
            }
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate = null)
        {
            try
            {
                if (predicate != null)
                {
                    return _dbSet.Where(predicate);
                }
                return _dbSet.AsEnumerable();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error getting entities!");
                throw new ArgumentNullException();
            }
        }


        public void Add(T entity)
        {
            try
            {
                _dbSet.Add(entity);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error adding entity {Entity}", entity);
            }
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }
    }
}