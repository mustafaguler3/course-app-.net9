using System;
using Course.Entities.Abstracts;

namespace Course.Entities.Concrete
{
	public class Category : BaseEntity
	{
		public string Name { get; set; }
		public string CoverUrl { get; set; }
	}
}

