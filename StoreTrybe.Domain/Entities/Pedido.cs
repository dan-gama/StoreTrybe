using StoreTrybe.Domain.Enums;

namespace StoreTrybe.Domain.Entities
{
    public class Pedido : Base
    {
        private readonly IList<PedidoItem> _itens;

        public Pedido(Cliente cliente)
        {
            Cliente = cliente;
            Status = EStatusPedido.Criado;
            _itens = new List<PedidoItem>();
        }

        public Cliente Cliente { get; private set; }
        public string Numero { get; private set; }
        public DateTime DataCompra { get; private set; }
        public EStatusPedido Status { get; private set; }
        public IReadOnlyCollection<PedidoItem> Items => _itens.ToArray();
        public Entrega Entrega { get; private set; }
        public void AdicionarItem(Produto produto, decimal quantidade)
        {
            var item = new PedidoItem(produto, quantidade);
            _itens.Add(item);
        }
    }
}