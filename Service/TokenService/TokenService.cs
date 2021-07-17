using Dominio.Entidades;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.TokenService
{
    public class TokenService : ITokenService
    {
        public string GerarToken(Usuario usuario)
        {
            var token = 
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("");
            throw new NotImplementedException();
        }
    }
}
