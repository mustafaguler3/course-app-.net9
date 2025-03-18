using System;
namespace Course.Business.DTOs
{
	public class RegisterDto
	{
		public string UserName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName { get; set; }
		public string PhoneNumber { get; set; }
	}
}

