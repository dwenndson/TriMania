using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class VoucherDesconto
    {
        public VoucherDesconto(int id, decimal valor, decimal porcentagem)
        {
            Id = id;
            Valor = valor;
            Porcentagem = porcentagem;
            Voucher = RandomVoucher(10);
        }

        [Required]
        public int Id { get; protected set; }
        [Required]
        public string Voucher { get; protected set; }
        public decimal Valor { get; protected set; }
        public decimal Porcentagem { get; protected set; }



        public static string RandomVoucher(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
