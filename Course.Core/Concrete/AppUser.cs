using System;
using Course.Entities.Abstracts;
using Microsoft.AspNetCore.Identity;

namespace Course.Entities.Concrete
{
	public class AppUser : IdentityUser<int>
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string ProfileImageUrl { get; set; }
		public string FullName { get; set; }
		public string PhoneNumber { get; set; }

	}
}

