using System;
namespace Sparky
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente c1 = new(1, "Mateus Barreto Santos", "16991277079");
            Endereco e1 = new(1, "15990365", "Rua dos Cria", 843, "Bairro das tia", "Cidade das Veia");

            Console.WriteLine("\t---------- Cadastro ----------");
            Console.WriteLine("ID: " + c1.getId() + "\nNome: " + Alinha(c1.getName()) + "\nTelefone: " + AplicarMascaraTelefone(c1.getTelefone()));
            Console.WriteLine("CEP: " + e1.getCep() + "\nRua: " + e1.getRua() + "\nNúmero: " + e1.getNumero() + "\nBairro: " + e1.getBairro() + "\nCidade: " + e1.getCidade() + "\n");

            c1.setName("Alberto");
            c1.setTelefone("1699807655");

            Console.WriteLine("Nome: " + Alinha(c1.getName()) + "\nTelefone: " + AplicarMascaraTelefone(c1.getTelefone()) + "\n");
        }
        private static string Alinha(string valor)
        {
            int campoCarac = 35;
            int tab = (campoCarac - valor.Length) + valor.Length;
            return valor.PadRight(tab, ' ');
        }
        private static string AplicarMascaraTelefone(string strNumero)
        {
            string strMascara = "{0:(00)0000-0000}";
            long lngNumero = Convert.ToInt64(strNumero);

            if (strNumero.Length == 11)
                strMascara = "{0:(00)00000-0000}";

            return string.Format(strMascara, lngNumero);
        }
    }
}

