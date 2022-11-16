namespace StoreTrybe.Domain.Entidades
{
    public class Produto : Base
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public int QtdeEstoque { get; set; }
        public decimal Preco { get; set; }
    }
}