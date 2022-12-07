namespace StoreTrybe.Domain.Entities
{
    public class Produto : Base
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public bool Ativo { get; private set; }
        public int QtdeEstoque { get; private set; }
        public decimal Preco { get; private set; }
    }
}