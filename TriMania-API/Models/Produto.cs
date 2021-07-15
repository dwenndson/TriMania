using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TriMania_API.Models
{
    public class Produto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        [Required]
        public decimal Valor_custo { get; set; }
        [Required]
        public decimal Valor_venda { get; set; }
        [Required]
        public Categoria Categoria { get; set; }
        public DateTime Data_cadastro { get; set; }
        public Usuario Autor_cadastro { get; set; }
        public bool Ativo { get; set; }

    }

    public class Categoria
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
    }
}
