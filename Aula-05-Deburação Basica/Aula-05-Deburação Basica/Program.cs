using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05_Deburação_Basica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome completo: ");
            string NomeCompleto = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            int Idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digire o número do seu documento: ");
            int NumeroDocumento = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o nome da sua rua: ");
            string NomeRua = Console.ReadLine();

            Console.WriteLine("Digite o número da sua casa: ");
            int NumeroCasa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe seu gênero: Pressione F para feminino e M para masculino ");
            char genero = Convert.ToChar(Console.ReadKey(true).KeyChar);


            Console.WriteLine("------------------------------");
            Console.WriteLine($"Olá {NomeRua}");
            Console.WriteLine($"Você tem {Idade} anos");
            Console.WriteLine($"O número do seu documento é {NumeroDocumento}");
            Console.WriteLine($"O nome da sua rua é {NomeRua}");
            Console.WriteLine($"O número da sua casa é {NumeroCasa}");
            Console.WriteLine($"O gênero informado é {genero}");
            Console.WriteLine("------------------------------");

            Console.WriteLine("Pressione qualquer tecla para encerrar o projeto: ");

            Console.ReadKey();

        }
    }
}
