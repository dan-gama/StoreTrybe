namespace StoreTrybe.Domain.Entities
{
    public class PedidoItem : Base
    {
        public PedidoItem(Produto produto, decimal quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
            Preco = produto.Preco;
        }

        public Produto Produto { get; private set; }
        public decimal Quantidade { get; private set; }
        public decimal Preco { get; private set; }
        public decimal PrecoTotal { get; private set; }

    }
}