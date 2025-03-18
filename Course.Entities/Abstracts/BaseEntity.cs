using System;
namespace Course.Entities.Abstracts
{
	public class BaseEntity : IEntity
	{
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; }
    }
}

