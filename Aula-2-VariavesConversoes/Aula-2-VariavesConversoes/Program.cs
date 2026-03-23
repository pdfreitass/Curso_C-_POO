using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2_VariavesConversoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Idade;
            Idade = 18;
            Console.WriteLine(Idade);

            Idade = 20;
            Console.WriteLine(Idade);

            string NomeCompleto = "Pedro Freitas";

            Console.WriteLine("Pedro Freitas");
            Console.WriteLine(NomeCompleto);

            NomeCompleto = "Joana Martins";
            Console.WriteLine(NomeCompleto);

            //byte b = 100000; O valor 100000 é maior do que o limite máximo de um byte, que é 255. Portanto, isso resultaria em um erro de compilação.

            var Salario = 10000;
            var NomeDaMae = "Joana";
            
            //NomeDaMae = "10000"; Isso não é permitido, pois a variável NomeDaMae foi inferida como uma string, e atribuir um valor numérico a ela causaria um erro de compilação.

            DateTime DataDeNascimento = new DateTime(2005, 5, 10, 7, 15, 10);
            Console.WriteLine(DataDeNascimento.Year);
            Console.WriteLine(DataDeNascimento.Month);
            Console.WriteLine(DataDeNascimento.Day);
            Console.WriteLine(DataDeNascimento.Hour);
            Console.WriteLine(DataDeNascimento.Minute);
            Console.WriteLine(DataDeNascimento.Second);

            string NumeroDaCasa = "65";
            int NumeroDaCasaConvertido = Convert.ToInt32(NumeroDaCasa);
            Console.WriteLine(NumeroDaCasaConvertido);

            string NumeroDaCasa2 = Convert.ToString(NumeroDaCasaConvertido);
            Console.WriteLine(NumeroDaCasa2);

            byte b = 50;
            char c = Convert.ToChar(b); // O valor 35 corresponde ao caractere '#' na tabela ASCII. Portanto, a variável 'c' conterá o caractere '#'.
            Console.WriteLine(c);


            int charC = Convert.ToInt32(c);
            Console.WriteLine(charC);


            double d = 1.6;
            Console.WriteLine(d);

            int ConversaoDouble = Convert.ToInt32(d); // O valor 1.6 é arredondado para o inteiro mais próximo, que é 2. Portanto, a variável 'ConversaoDouble' conterá o valor 2.
            Console.WriteLine(ConversaoDouble);

            int NumeroGrande = 1000;
            byte Numeropequeno = Convert.ToByte(NumeroGrande); // O valor 1000 é maior do que o limite máximo de um byte, que é 255. Portanto, isso resultaria em um erro de compilação.
            Console.WriteLine(Numeropequeno);
            
            Console.ReadKey();

        }
    }
}
