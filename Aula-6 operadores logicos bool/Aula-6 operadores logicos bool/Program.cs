using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6_operadores_logicos_bool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool var1 = true;
            bool var2 = false;

            //Negação = !

            bool ResultadoNegacao = !var1;
            Console.WriteLine($"Resultado da Negação de {var1} é: {ResultadoNegacao}");
            ResultadoNegacao = !var2;
            Console.WriteLine($"Resultado da Negação de {var2} é: {ResultadoNegacao}");

            //Operador E (AND) = &
            bool resultadoE = var1 & var1;
            Console.WriteLine($"Resultado do operador E entre {var1} e {var1} é: {resultadoE}");
            resultadoE = var1 & var2;
            Console.WriteLine($"Resultado do operador E entre {var1} e {var2} é: {resultadoE}");
            resultadoE = var2 & var2;
            Console.WriteLine($"Resultado do operador E entre {var2} e {var2} é: {resultadoE}");

            //Operador OU (OR) = |
            bool resultadoOU = var1 | var1;
            Console.WriteLine($"Resultado do operador OU entre {var1} e {var1} é: {resultadoOU}");
            resultadoOU = var1 | var2;
            Console.WriteLine($"Resultado do operador OU entre {var1} e {var2} é: {resultadoOU}");
            resultadoOU = var2 | var2;
            Console.WriteLine($"Resultado do operador OU entre {var2} e {var2} é: {resultadoOU}");

            //Operador OU Exclusivo (XOR) = ^
            bool resultadoXOR = var1 ^ var1;
            Console.WriteLine($"Resultado do operador XOR entre {var1} e {var1} é: {resultadoXOR}");
            resultadoXOR = var1 ^ var2;
            Console.WriteLine($"Resultado do operador XOR entre {var1} e {var2} é: {resultadoXOR}");
            resultadoXOR = var2 ^ var2;
            Console.WriteLine($"Resultado do operador XOR entre {var2} e {var2} é: {resultadoXOR}");
            )g

            Console.ReadKey();
        }

    }
}
