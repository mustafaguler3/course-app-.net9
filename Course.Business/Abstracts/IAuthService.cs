using System;
using Course.Business.DTOs;

namespace Course.Business.Abstracts
{
	public interface IAuthService
	{
		Task<string> RegisterAsync(RegisterDto registerDto);
		Task<string> LoginAsync(LoginDto loginDto);
	}
}

