using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using University.Application.Interfaces.Repositories;
using University.Domain.HttpModels;

namespace University.Persistence.Services
{
    public class IdentityService : IIdentityService
    {
        public Task<LoginResponseModel> Login(LoginRequestModel requestModel)
        {

            if (requestModel.Email != "admin@gmail.com" || requestModel.Password != "123456")
            {
                return null;
            }

            var claims = new Claim[]
            {
                new Claim(ClaimTypes.NameIdentifier, requestModel.Email),
                new Claim(ClaimTypes.Name, "Admin"),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("UniversitySecretKeyShouldBeLong"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiry = DateTime.Now.AddDays(10);

            var token = new JwtSecurityToken(claims: claims, expires: expiry, signingCredentials: creds, notBefore: DateTime.Now);

            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(token);

            LoginResponseModel response = new()
            {
                UserToken = encodedJwt,
                Email = requestModel.Email
            };

            return Task.FromResult(response);
        }

    }
}
