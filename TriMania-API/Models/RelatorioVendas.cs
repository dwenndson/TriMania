using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriMania_API.Enums;

namespace TriMania_API.Models
{
    public class RelatorioVendas
    {
        public int Total_pedidos_concluidos { get; set; }
        public int Total_pedidos_cancelados { get; set; }
        public decimal Valor_total_pedidos_sem_desconto { get; set; }
        public decimal Valor_total_pedidos_com_desconto { get; set; }
        public VendaProduto Pedido { get; set; }
        public string Periodo_filtrados { get; set; }
        public Status[] Status_filtrados { get; set; }
        public string[] Usuarios_filtrados { get; set; }
    }
}
