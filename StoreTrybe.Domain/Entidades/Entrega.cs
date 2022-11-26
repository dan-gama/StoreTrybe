using StoreTrybe.Domain.Enums;

namespace StoreTrybe.Domain.Entidades
{
    public class Entrega : Base
    {
        public DateTime DataEntrega { get; set; }
        public EStatusEntrega Status { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
    }
}