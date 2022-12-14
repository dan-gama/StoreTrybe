using StoreTrybe.Domain.Entities;
using StoreTrybe.Domain.ValueObjects;

namespace StoreTrybe.Tests;

public class ClienteTest
{
    [Fact]
    public void ClienteOk_QuandoValidado()
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

        string cpf = "32132132145";

        // Objeto de cliente        
        Cliente cliente = new Cliente(nome, cpf, "danilo.gama@gmail.com", "61999445059");

        cliente.ValidarEntidade();

        Assert.True(cliente.EntidadeValida);
    }

    [Fact]
    public void ClienteInvalido_QuandoCPFVazio()
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

        string cpf = "";

        // Objeto de cliente        
        Cliente cliente = new Cliente(nome, cpf, "danilo.gama@gmail.com", "61999445059");

        cliente.ValidarEntidade();

        Assert.False(cliente.EntidadeValida);
    }

    [Fact]
    public void ClienteInvalido_QuandoPrimeiroNomeVazio()
    {
        // Objeto de nome
        Nome nome = new Nome("", "Gama");

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

        string cpf = "32326546897";

        // Objeto de cliente        
        Cliente cliente = new Cliente(nome, cpf, "danilo.gama@gmail.com", "61999445059");

        cliente.ValidarEntidade();

        Assert.False(cliente.EntidadeValida);
    }
}