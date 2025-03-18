using System;
using System.Linq.Expressions;
using Course.Core.Abstracts;
using Course.DataAccess.Context;
using Course.Entities.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace Course.DataAccess.Repositories
{
	public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new()
	{
        private readonly CourseDbContext _context;
        private readonly DbSet<T> _dbSet;

		public GenericRepository(CourseDbContext courseDbContext)
		{
            _context = courseDbContext;
            _dbSet = _context.Set<T>();
		}

        public async Task AddAsync(T entity)
        {
            entity.CreatedDate = DateTime.UtcNow;
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id) => await _dbSet.FindAsync(id);

        public void Update(T entity)
        {
            entity.UpdatedDate = DateTime.UtcNow;
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }
    }
}

