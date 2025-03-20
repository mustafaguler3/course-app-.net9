using System;
using System.ComponentModel.DataAnnotations;
using Course.Business.Abstracts;
using Course.Business.DTOs;
using Course.Business.DTOs.Response;
using Course.Core.Security;
using Course.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace Course.Business.Concrete
{
	public class AuthService: IAuthService
	{
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly JwtTokenProvider _tokenProvider;
        private readonly ILogger<AuthService> _logger;

        public AuthService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, JwtTokenProvider tokenProvider, ILogger<AuthService> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenProvider = tokenProvider;
            _logger = logger;
        }

        public async Task<AuthResponseDto> LoginAsync(LoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);
            if (user == null)
            {
                return new AuthResponseDto
                {
                    Success = false,
                    Message = "User not found"
                };
            }

            var result = await _signInManager.PasswordSignInAsync(user, loginDto.Password, false, false);

            if (!result.Succeeded)
            {
                return new AuthResponseDto
                {
                    Success = false,
                    Message = "Login failed"
                };
            }

            var token = _tokenProvider.GenerateToken(user);

            return new AuthResponseDto
            {
                Success = true,
                Token = token
            };
        }

        public async Task<AuthResponseDto> RegisterAsync(RegisterDto registerDto)
        {
            var user = new AppUser
            {
                UserName = registerDto.UserName,
                Email = registerDto.Email,
                FirstName = registerDto.FirstName,
                LastName = registerDto.LastName,
                PhoneNumber = registerDto.PhoneNumber,
                FullName = registerDto.FullName
            };

            var result = await _userManager.CreateAsync(user, registerDto.Password);
            
            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(e => e.Description).ToList();
                _logger.LogError(string.Join(Environment.NewLine, errors));
                return new AuthResponseDto()
                {
                    Success = false,
                    Message = "Registration failed",
                    Errors = errors
                };
            }
            var token = _tokenProvider.GenerateToken(user);
            
            return new AuthResponseDto(){Success = true, Token = token};
        }
    }
}

