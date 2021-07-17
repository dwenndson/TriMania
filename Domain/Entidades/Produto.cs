using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Produto : EntidadeBase
    {
        public Produto(string nome, string descricao, decimal valor_custo, decimal valor_venda, Categoria categoria, DateTime data_cadastro, Usuario autor_cadastro, bool ativo)
        {
            Nome = nome;
            Descricao = descricao;
            Valor_custo = valor_custo;
            Valor_venda = valor_venda;
            Categoria = categoria;
            Data_cadastro = data_cadastro;
            Autor_cadastro = autor_cadastro;
            Ativo = ativo;
        }

        Produto() { }
        [Required]
        public string Nome { get; protected set; }
        public string Descricao { get; protected set; }
        [Required]
        public decimal Valor_custo { get; protected set; }
        [Required]
        public decimal Valor_venda { get; protected set; }
        [Required]
        public Categoria Categoria { get; protected set; }
        public DateTime Data_cadastro { get; protected set; }
        public Usuario Autor_cadastro { get; protected set; }
        public bool Ativo { get; protected set; }

    }
   
}
