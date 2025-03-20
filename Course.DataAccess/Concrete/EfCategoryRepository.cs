using System;

using Course.DataAccess.Context;
using Course.DataAccess.Repositories;
using Course.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Course.DataAccess.Concrete
{
    public class EfCategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly CourseDbContext _dbContext;

        public EfCategoryRepository(CourseDbContext courseDbContext) : base(courseDbContext)
        {
            _dbContext = courseDbContext;
        }
        
        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await _dbContext.Categories.ToListAsync();
        }
    }
}

