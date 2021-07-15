using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TriMania_API.Models
{
    public class VoucherDesconto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Voucher = RandomString(10);
        public decimal Valor { get; set; }
        public decimal Porcentagem { get; set; }



        public static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
