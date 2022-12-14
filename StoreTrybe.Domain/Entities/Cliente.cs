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

        public void ValidarEntidade()
        {
            if (String.IsNullOrEmpty(Nome.PrimeiroNome))
                AdicionarNotificacao("Primeiro Nome", "O primeiro nome é obrigatório");

            if (String.IsNullOrEmpty(Nome.SobreNome))
                AdicionarNotificacao("Sobrenome", "O sobrenome é obrigatório");

            if (String.IsNullOrEmpty(CPF))
                AdicionarNotificacao("CPF", "O CPF é obrigatório");

            // Seta se a entidade é valida
            VerificarEntidade();
        }
    }
}