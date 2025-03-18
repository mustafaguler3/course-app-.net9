using System;
using Course.Business.DTOs;

namespace Course.Business.Abstracts
{
	public interface ICategoryService
	{ 
		Task<List<CategoryDto>> GetCategoriesAsync();
	}
}

