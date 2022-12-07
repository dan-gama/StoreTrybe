namespace StoreTrybe.Domain.Entities
{
    public abstract class Base
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