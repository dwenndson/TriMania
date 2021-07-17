using Dominio.Enums;

namespace Dominio.Entidades
{
    public class RelatorioVendas
    {
        public RelatorioVendas(int total_pedidos_concluidos, int total_pedidos_cancelados, decimal valor_total_pedidos_sem_desconto, decimal valor_total_pedidos_com_desconto, VendaProduto pedido, string periodo_filtrados, Status[] status_filtrados, string[] usuarios_filtrados)
        {
            Total_pedidos_concluidos = total_pedidos_concluidos;
            Total_pedidos_cancelados = total_pedidos_cancelados;
            Valor_total_pedidos_sem_desconto = valor_total_pedidos_sem_desconto;
            Valor_total_pedidos_com_desconto = valor_total_pedidos_com_desconto;
            Pedido = pedido;
            Periodo_filtrados = periodo_filtrados;
            Status_filtrados = status_filtrados;
            Usuarios_filtrados = usuarios_filtrados;
        }

        public int Total_pedidos_concluidos { get; protected set; }
        public int Total_pedidos_cancelados { get; protected set; }
        public decimal Valor_total_pedidos_sem_desconto { get; protected set; }
        public decimal Valor_total_pedidos_com_desconto { get; protected set; }
        public VendaProduto Pedido { get; protected set; }
        public string Periodo_filtrados { get; protected set; }
        public Status[] Status_filtrados { get; protected set; }
        public string[] Usuarios_filtrados { get; protected set; }
    }
}
