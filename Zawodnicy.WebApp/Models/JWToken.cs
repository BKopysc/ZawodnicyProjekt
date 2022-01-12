using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zawodnicy.WebApp.Models
{
    //Generowanie JWToken
    public class JWToken
    {
        private IConfiguration Configuration;

        public string TokenUrl { get; set; }
        public string SecretKey { get; set; }
        public string TokenString { get; set; }
        public JWToken(IConfiguration configuration)
        {
            Configuration = configuration;

            TokenUrl = "http://localhost:5001";
            SecretKey = "SuperTajneHaslo111222";
            TokenString = GenerateJSONWebToken();
        }

        private string GenerateJSONWebToken()
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes($"{SecretKey}"));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: $"{TokenUrl}",
                audience: $"{TokenUrl}",
                expires: DateTime.Now.AddHours(3),
                signingCredentials: credentials
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
