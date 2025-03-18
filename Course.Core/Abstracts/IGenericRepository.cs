using System;
using System.Linq.Expressions;
using Course.Entities.Abstracts;

namespace Course.Core.Abstracts
{
	public interface IGenericRepository<T> where T : class, IEntity, new()
	{
		Task<T> GetByIdAsync(int id);
		Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression);
		Task AddAsync(T entity);
		void Delete(T entity);
		void Update(T entity);
	}
}

