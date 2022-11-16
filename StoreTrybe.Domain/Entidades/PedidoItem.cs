namespace StoreTrybe.Domain.Entidades
{
    public class PedidoItem : Base
    {
        public Produto Produto { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal PrecoTotal { get; set; }
        public int Quantidade { get; set; }
    }
}