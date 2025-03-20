using System;
using Course.Business.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace Course.API.Controllers
{
	[Route("api/categories")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Categories()
        {
            var categories = await _categoryService.GetCategoriesAsync();
            
            if (categories == null || categories.Count == 0)
            {
                return NotFound("Kategori bulunamadı veya veri yok.");
            }
            
            return Ok(categories);
        }
    }
}

