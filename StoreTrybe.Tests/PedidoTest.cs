using StoreTrybe.Domain.Entities;
using StoreTrybe.Domain.ValueObjects;

namespace StoreTrybe.Tests;

public class PedidoTest
{
    [Fact]
    public void VerificarCodigoProduto_QuandoPedidoCriado()
    {
        // Objeto de nome
        Nome nome = new Nome("Danilo", "Gama");

        // Objeto de endereço
        Endereco endereco = new Endereco(
            "BR",
            "GO",
            "Águas Lindas de Goiás",
            "Águas Bonitas I",
            "Quadra 34, Rua 8, Lote 7",
            "7",
            null,
            "72926066",
            true
        );

        // Objeto de cliente        
        Cliente cliente = new Cliente(nome, "25994568735", "danilo.gama@gmail.com", "61999445059");
        cliente.AdicionarEndereco(endereco);
    }
}