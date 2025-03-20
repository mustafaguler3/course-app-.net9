using System;
using System.ComponentModel.DataAnnotations;

namespace Course.Business.DTOs
{
	public class RegisterDto
	{
		[Required(ErrorMessage = "Username is required.")]
		[RegularExpression(@"^[a-zA-Z0-9]*$", 
			ErrorMessage = "Username can only contain letters, numbers, '-' and '_'.")]
		public string UserName { get; set; }
		[Required(ErrorMessage = "Email is required.")]
		[EmailAddress(ErrorMessage = "Invalid email format.")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Password is required.")]
		[MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
		[MaxLength(20, ErrorMessage = "Password cannot exceed 20 characters.")]
		public string Password { get; set; }

		[Required(ErrorMessage = "First name is required.")]
		[MaxLength(50, ErrorMessage = "First name cannot exceed 50 characters.")]
		public string FirstName { get; set; }

		[Required(ErrorMessage = "Last name is required.")]
		[MaxLength(50, ErrorMessage = "Last name cannot exceed 50 characters.")]
		public string LastName { get; set; }

		[Required(ErrorMessage = "Full name is required.")]
		public string FullName { get; set; }

		[Required(ErrorMessage = "Phone number is required.")]
		[RegularExpression(@"^\d{10,15}$", ErrorMessage = "Phone number must be between 10 and 15 digits.")]
		public string PhoneNumber { get; set; }
	}
}

