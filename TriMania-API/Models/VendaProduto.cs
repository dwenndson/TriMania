using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriMania_API.Enums;

namespace TriMania_API.Models
{
    public class VendaProduto
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public decimal Valor_bruto { get; set; }
        public decimal Valor_liquido { get; set; }
        public VoucherDesconto Voucher { get; set; }
        public Produto[] Items { get; set; }
        public DateTime Data_criacao { get; set; }
        public DateTime Data_cancelamento { get; set; }
        public Status Status { get; set; }
        public DateTime Data_conclusao { get; set; }
    }
}
