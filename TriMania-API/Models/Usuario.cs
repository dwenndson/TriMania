using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TriMania_API.Models
{
    public class Usuario 
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        public string Email { get; set; }
        public DateTime Data_de_nascimento { get; set; }
        [Required]
        public DateTime Data_de_cadastro { get; set; }
        public Endereco endereco { get; set; }

        public class Endereco
        {
            public string Rua { get; set; }
            public string Bairro { get; set; }
            public string Numero { get; set; }
            public string Cidade { get; set; }
            public string Estado { get; set; }
        }
    }
}
