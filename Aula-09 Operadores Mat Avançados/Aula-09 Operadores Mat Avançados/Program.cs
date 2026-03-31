using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_09_Operadores_Mat_Avançados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Potenciação
            double potencia = Math.Pow(4, 2);
            Console.WriteLine("Potenciação: " + potencia);

            //Radiciação
            double raiz = 3;
            double radiciacao = Math.Pow(27, 1/raiz);
            Console.WriteLine("Radiciação: " + radiciacao);

            //maximo e minimo
            double maximo = Math.Max(4, 8);
            double minimo = Math.Min(4, 8);
            Console.WriteLine("Máximo: " + maximo);
            Console.WriteLine("Mínimo: " + minimo);

            //modulo
            double modulo = Math.Abs(-10);
            Console.WriteLine("Módulo: " + modulo);

            //Operações trigonométricas
            //Seno = sin
            //Cosseno = cos
            //Tangente = tan
            double angulo = 30 * (2*Math.PI) / 360;
            double seno = Math.Sin(angulo);
            double cosseno = Math.Cos(angulo);
            Console.WriteLine("Seno: " + seno);

            //Arcoseno = asin
            //Arccosseno = acos
            //Arctangente = atan
            double arcoSeno = Math.Asin(seno);
            double arcoCosseno = Math.Acos(cosseno);
            Console.WriteLine("Arcoseno: " + arcoSeno);
            double arcsenoGraus = arcoSeno * 360 / (2 * Math.PI);
            Console.WriteLine("Arcoseno em graus: " + arcsenoGraus);

            //Arredondamento
            double numero = 3.33;
            double arredondamentoParaCima = Math.Ceiling(numero);
            double arredondamentoParaBaixo = Math.Floor(numero);
            Console.WriteLine("Arredondamento para cima: " + arredondamentoParaCima);
            Console.WriteLine("Arredondamento para baixo: " + arredondamentoParaBaixo);

            //Logaritmo
            double base10 = Math.Log10(100);
            double baseE = Math.Log(Math.E);
            Console.WriteLine("Logaritmo base 10: " + base10);
            Console.WriteLine("Logaritmo base e: " + baseE);
        }
    }
}
