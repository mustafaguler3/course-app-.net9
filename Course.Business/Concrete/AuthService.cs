using System;
using Course.Business.Abstracts;
using Course.Business.DTOs;
using Course.Core.Security;
using Course.Entities.Concrete;
using Microsoft.AspNetCore.Identity;

namespace Course.Business.Concrete
{
	public class AuthService: IAuthService
	{
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly JwtTokenProvider _tokenProvider;

        public AuthService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, JwtTokenProvider tokenProvider)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenProvider = tokenProvider;
        }

        public async Task<string> LoginAsync(LoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);
            if (user == null) return "User not found";

            var result = await _signInManager.PasswordSignInAsync(user, loginDto.Password, false, false);

            if (!result.Succeeded) return "Login failed";

            return _tokenProvider.GenerateToken(user);
        }

        public async Task<string> RegisterAsync(RegisterDto registerDto)
        {
            var user = new AppUser
            {
                UserName = registerDto.UserName,
                Email = registerDto.Email,
                FirstName = registerDto.FirstName,
                LastName = registerDto.LastName,
                PhoneNumber = registerDto.PhoneNumber,
                FullName = registerDto.FullName,
                Password = registerDto.Password
            };

            var result = await _userManager.CreateAsync(user, registerDto.Password);
            if (!result.Succeeded)
            {
                return "Register failed";
            }

            return _tokenProvider.GenerateToken(user);
        }
    }
}

