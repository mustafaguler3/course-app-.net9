using System;
using AutoMapper;
using Course.Business.DTOs;
using Course.Entities.Concrete;

namespace Course.Core.Mapper
{
	public class MapperProfile : Profile
	{
		public MapperProfile()
		{
			CreateMap<Category, CategoryDto>().ReverseMap();
		}
	}
}

