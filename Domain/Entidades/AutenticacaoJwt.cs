using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class AutenticacaoJwt
    {
        public AutenticacaoJwt(int id, string userName, string password, string role)
        {
            Id = id;
            UserName = userName;
            Password = password;
            Role = role;
        }

        public int Id { get; set; }
        [Required]
        public string UserName { get; protected set; }
        [Required]
        public string Password { get; protected set; }
        public string Role { get; protected set; }


    }
}
