using StoreTrybe.API.Models.Cliente;
using StoreTrybe.Domain.Entities;
using StoreTrybe.Domain.ValueObjects;

namespace StoreTrybe.API.Services
{
    public class ClienteService
    {
        public IEnumerable<ResponseCliente> GetAll()
        {
            // Lista de clientes
            var lstCliente = new List<Cliente>();

            // Dados mockados
            var cliente1 = new Cliente(new Nome("Danilo", "Gama"), "11111111111", "danilo@gmail.com", "6199665588");
            lstCliente.Add(cliente1);

            lstCliente.Add(new Cliente(new Nome("Cristovão", "Colombo"), "22222222222", "cristovao@gmail.com", "6188554477"));
            lstCliente.Add(new Cliente(new Nome("Daniela", "Neves"), "33333333333", "daniela@gmail.com", "6199556688"));

            // Transformar a classe Cliente na classe ResponseCliente
            var lstResponseCliente = new List<ResponseCliente>();
            foreach (var item in lstCliente)
            {
                lstResponseCliente.Add(new ResponseCliente()
                {
                    Id = item.Id.ToString(),
                    Nome = item.Nome.PrimeiroNome + " " + item.Nome.SobreNome,
                    CPF = item.CPF,
                    Telefone = item.Telefone
                });
            }

            return lstResponseCliente;
        }
    }
}