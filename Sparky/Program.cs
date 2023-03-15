using System;
namespace Sparky
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente c1 = new(1, "Leonardo Vallim", "16991277079");
            Endereco e1 = new(1, "15990365", "Rua dos bandidos", 843, "Bairro das antas ", "Cidade das coroa");

            Console.WriteLine("\t---------- Cadastro ----------");
            Console.WriteLine("ID: " + c1.getId() + "\nNome: " + (c1.getName()) + "\nTelefone: " + (c1.getTelefone()));
            Console.WriteLine("CEP: " + e1.getCep() + "\nRua: " + e1.getRua() + "\nNúmero: " + e1.getNumero() + "\nBairro: " + e1.getBairro() + "\nCidade: " + e1.getCidade() + "\n");

            c1.setName("Alberto");
            c1.setTelefone("1699807655");

            Console.WriteLine("Nome: " + (c1.getName()) + "\nTelefone: " + (c1.getTelefone()) + "\n");
        }
    }
}

