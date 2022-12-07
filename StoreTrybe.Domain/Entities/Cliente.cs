using StoreTrybe.Domain.ValueObjects;

namespace StoreTrybe.Domain.Entities
{
    public class Cliente : Base
    {
        private readonly IList<Endereco> _enderecos;

        public Cliente(Nome nome, string cpf, string email, string telefone)
        {
            Nome = nome;
            CPF = cpf;
            Email = email;
            Telefone = telefone;
        }

        public Nome Nome { get; private set; }
        public string CPF { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public IReadOnlyCollection<Endereco> Enderecos => _enderecos.ToArray();
        public void AdicionarEndereco(Endereco endereco)
        {
            _enderecos.Add(endereco);
        }
    }
}