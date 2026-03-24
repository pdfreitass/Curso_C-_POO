using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_3_EntradasDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome:");
            string Nome = Console.ReadLine();
            Console.WriteLine($"Olá {Nome}");

            Console.WriteLine("Digite a sua idade:");
            int Idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Você tem {Idade} anos de idade");

            Console.WriteLine("Pressione qualquer teclar");
            char TeclaPressionada = Console.ReadKey(true).KeyChar;

            string TeclaPressionadaString = Convert.ToString(Console.ReadKey(true).KeyChar);

            Console.WriteLine($"Olá a tecla que você pressionou foi: {TeclaPressionada}");

            Console.WriteLine("Pressione qualquer tecla para sair");

            Console.ReadKey();
        }
    }
}
