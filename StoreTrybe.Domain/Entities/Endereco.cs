namespace StoreTrybe.Domain.Entities
{
    public class Endereco
    {
        public Endereco(string pais, string uf, string cidade, string bairro, string logradouro, string numero, string complemento, string cep, bool padrao)
        {
            Pais = pais;
            UF = uf;
            Cidade = cidade;
            Bairro = bairro;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            CEP = cep;
            Padrao = padrao;
        }

        public string Pais { get; private set; }
        public string UF { get; private set; }
        public string Cidade { get; private set; }
        public string Bairro { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string CEP { get; private set; }
        public bool Padrao { get; private set; }
    }
}