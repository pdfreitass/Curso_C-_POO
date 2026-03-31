using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_08_Operadores_Matematicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //soma
            double num1 = 15.5;
            double num2 = 10;
            double resultadoSoma = num1 + num2;
            Console.WriteLine($"A soma entre {num1} mais {num2} é {resultadoSoma}");
            

            //subtração
            double resultadoSubtracao = num1 - num2;
            Console.WriteLine($"A subtração entre {num1} menos {num2} é {resultadoSubtracao}");


            //multiplicação
            double resultadoMultiplicacao = num1 * num2;
            Console.WriteLine($"A multiplicação entre {num1} vezes {num2} é {resultadoMultiplicacao}");

            //divisão
            double resultadoDivisao = num1 / num2;
            Console.WriteLine($"A divisão entre {num1} dividido por {num2} é {resultadoDivisao}");

            //resto da divisão
            int numero3 = 5;
            int numero4 = 3;
            int resultadoRestoDivisao = numero3 % numero4;
            Console.WriteLine($"O resto da divisão entre {numero3} dividido por {numero4} é {resultadoRestoDivisao}");

            //somar ou subtrair um valor a uma variável
            double numero5 = 10;
            numero5 += 10;//numero5 = numero5 + 10;
            Console.WriteLine($"A soma entre 10 mais 10 é {numero5}");

            numero5 = 10;
            numero5 -= 10;//numero5 = numero5 - 10;
            Console.WriteLine($"A subtração entre 10 menos 10 é {numero5}");

            //dividir e multiplicar um valor a uma variável
            numero5 = 10;
            numero5 *= 10;//numero5 = numero5 * 10;
            Console.WriteLine($"A multiplicação entre 10 vezes 10 é {numero5}");

            numero5 = 10;
            numero5 /= 10;//numero5 = numero5 / 10;
            Console.WriteLine($"A divisão entre 10 por 10 é {numero5}");

            //incremento ++
            double numero6 = 10;
            //numero6 = numero6 + 1;
            //numero6 += 1;
            numero6++;
            Console.WriteLine($"O incremento de 10 é {numero6}");

            //decremento --
            double numero7 = 10;
            //numero7 = numero7 - 1;
            //numero7 -= 1;
            numero7--;
            Console.WriteLine($"O decremento de 10 é {numero7}");
            
            Console.ReadKey();
        }

    }

}

