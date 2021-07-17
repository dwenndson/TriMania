using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class Usuario : EntidadeBase
    {
        public Usuario(string nome, string cpf, string email, DateTime data_de_nascimento, DateTime data_de_cadastro, EnderecoEntity endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Data_de_nascimento = data_de_nascimento;
            Data_de_cadastro = data_de_cadastro;
            Endereco = endereco;
        }

        [Required]
        public string Nome { get; protected set; }
        [Required]
        public string Cpf { get; protected set; }
        [Required]
        public string Email { get; protected set; }
        public DateTime Data_de_nascimento { get; protected set; }
        [Required]
        public DateTime Data_de_cadastro { get; protected set; }
        public EnderecoEntity Endereco { get; protected set; }
    }
}
