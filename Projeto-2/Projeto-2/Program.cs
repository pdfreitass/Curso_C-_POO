using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pressione A para alugar um filme e S para sair da locadora: ");
            char Opcao = Console.ReadKey(true).KeyChar;

            if (Opcao == 'A' || Opcao == 'a') 
            {
                Console.WriteLine("Pressione 1 para alugar top gun.");
                Console.WriteLine("Pressione 2 para alugar a bela e a fera.");
                Console.WriteLine("Pressione 3 para alugar o Homem - Aranha.");
                int Filme = Convert.ToInt32(Console.ReadKey(true).KeyChar.ToString());

                switch (Filme)
                {
                    case 1:
                        Console.WriteLine("Você alugou o filme top gun.");
                        break;
                    case 2:
                        Console.WriteLine("Você alugou o filme a bela e a fera.");
                        break;
                    case 3:
                        Console.WriteLine("Você alugou o filme o Homem - Aranha.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }

            else if (Opcao == 'S' || Opcao == 's') 
            {
                Console.WriteLine("Obrigado por visitar a locadora, volte sempre!");
            }
            else {
                Console.WriteLine("Opção inválida.");
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();

        }
    }
}
