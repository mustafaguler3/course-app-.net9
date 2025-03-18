using System;
using AutoMapper;
using Course.Business.Abstracts;
using Course.Business.DTOs;
using Course.DataAccess.Repositories;

namespace Course.Business.Concrete
{
    public class CategoryService : ICategoryService
	{
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<List<CategoryDto>> GetCategoriesAsync()
        {
            var categories = await _categoryRepository.GetAllCategoriesAsync();

            return _mapper.Map<List<CategoryDto>>(categories);
        }
    }
}

