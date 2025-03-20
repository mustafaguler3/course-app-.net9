using System;
using Course.Business.DTOs;
using Course.Business.DTOs.Response;

namespace Course.Business.Abstracts
{
	public interface IAuthService
	{
		Task<AuthResponseDto> RegisterAsync(RegisterDto registerDto);
		Task<AuthResponseDto> LoginAsync(LoginDto loginDto);
	}
}

