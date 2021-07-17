using Dominio.Enums;
using System;

namespace Dominio.Entidades
{
    public class VendaProduto
    {
        public VendaProduto(int id, Usuario usuario, decimal valor_bruto, decimal valor_liquido, VoucherDesconto voucher, Produto[] items, DateTime data_criacao, DateTime data_cancelamento, Status status, DateTime data_conclusao)
        {
            Id = id;
            Usuario = usuario;
            Valor_bruto = valor_bruto;
            Valor_liquido = valor_liquido;
            Voucher = voucher;
            Items = items;
            Data_criacao = data_criacao;
            Data_cancelamento = data_cancelamento;
            Status = status;
            Data_conclusao = data_conclusao;
        }

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
