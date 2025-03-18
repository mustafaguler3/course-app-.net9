using System;
using Course.Core.Abstracts;
using Course.Entities.Concrete;

namespace Course.DataAccess.Repositories
{
	public interface ICategoryRepository : IGenericRepository<Category>
	{
		Task<List<Category>> GetAllCategoriesAsync();
	}
}

