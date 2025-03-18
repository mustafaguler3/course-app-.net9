using System;
using Course.Business.Abstracts;
using Course.Business.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Course.API.Controllers
{
	[Route("api/auth/")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        {
            var result = await _authService.RegisterAsync(registerDto);
            return Ok(new { token = result });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            var result = await _authService.LoginAsync(loginDto);
            return Ok(new { token = result });
        }
    }
}

