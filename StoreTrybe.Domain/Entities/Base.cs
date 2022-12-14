using StoreTrybe.Domain.Notifications;

namespace StoreTrybe.Domain.Entities
{
    public abstract class Base : Notificacao
    {
        protected Base()
        {
            Id = Guid.NewGuid();
            DataCadastro = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public DateTime DataCadastro { get; private set; }
    }
}