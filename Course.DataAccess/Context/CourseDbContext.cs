using System;
using Course.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Course.DataAccess.Context
{
	public class CourseDbContext : IdentityDbContext<AppUser, IdentityRole<int>,int>
	{
		public CourseDbContext(DbContextOptions<CourseDbContext> options):base(options)
		{
		}
		public DbSet<Category> Categories { get; set; }
		public DbSet<AppUser> Users { get; set; }
	}
}

