using System;
using Course.Entities.Abstracts;
using Microsoft.AspNetCore.Identity;

namespace Course.Entities.Concrete
{
	public class AppUser : IdentityUser<int>
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName { get; set; }
		public string PhoneNumber { get; set; }

	}
}

