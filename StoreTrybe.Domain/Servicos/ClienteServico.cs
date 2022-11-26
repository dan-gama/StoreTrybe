using StoreTrybe.Domain.Entidades;

namespace StoreTrybe.Domain.Servicos
{
    public class ClienteServico
    {
        public bool Criar(Cliente cliente)
        {
            if (ValidarCliente(cliente) == false)
            {
                return false;
            }
            else
            {
                // 02 - Criar o cliente no banco de dados
                return true;
            }
        }

        public bool Alterar(Cliente cliente)
        {
            if (ValidarCliente(cliente) == false)
            {
                return false;
            }
            else
            {
                // 02 - Criar o cliente no banco de dados
                return true;
            }
        }

        public bool ValidarCliente(Cliente cliente)
        {
            // Regra 01: O nome do cliente não pode ser nulo ou branco
            if (cliente.Nome == "" || cliente.CPF == "")
                return false;

            // Cliente validado - Ok
            return true;
        }
    }
}