using StoreTrybe.Domain.Enums;

namespace StoreTrybe.Domain.Entities
{
    public class Entrega : Base
    {
        public Entrega(DateTime dataEntrega, Endereco endereco)
        {
            DataEntrega = dataEntrega;
            Status = EStatusEntrega.EsperandoEnvio;
            Endereco = endereco;
        }

        public Endereco Endereco { get; private set; }
        public DateTime DataEntrega { get; private set; }
        public EStatusEntrega Status { get; private set; }
    }
}