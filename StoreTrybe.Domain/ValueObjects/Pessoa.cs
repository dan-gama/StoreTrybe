namespace StoreTrybe.Domain.ValueObjects
{
    public class Nome
    {
        public Nome(string nome, string sobreNome)
        {
            PrimeiroNome = nome;
            SobreNome = sobreNome;
        }

        public string PrimeiroNome { get; private set; }
        public string SobreNome { get; private set; }
    }
}