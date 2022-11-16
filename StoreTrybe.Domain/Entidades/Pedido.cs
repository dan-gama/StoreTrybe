using StoreTrybe.Domain.Enums;

namespace StoreTrybe.Domain.Entidades
{
    public class Pedido : Base
    {
        public Cliente Cliente { get; set; }
        public string OrdemServico { get; set; }
        public DateTime DataCompra { get; set; }
        public EStatusPedido Status { get; set; }
        public List<PedidoItem> Items { get; set; }
        public decimal PrecoTotal { get; set; }
    }
}