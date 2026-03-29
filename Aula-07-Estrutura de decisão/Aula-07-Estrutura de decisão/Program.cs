using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_07_Estrutura_de_decisão
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());
            //if(se)... else(se não)...
            if (idade >= 18/*condição Booleana, pode ser true ou false*/)
            {
                Console.WriteLine("Você é maior de idade!");
            }
            else //opcional
            {
                Console.WriteLine("Você é menor de idade!");
            }

            Console.WriteLine("Digite o seu salário:");
            UInt32 Salario = Convert.ToUInt32(Console.ReadLine());

            //if... else if... else
            if (Salario < 1000)//Sempre precisa ter uma condição para validar os dados de entrada, para evitar erros no programa
            {
                Console.WriteLine("Você ganha menos que 1 salário minímo");
            }
            else if (Salario < 2000)//Pode ter quantos else if for necessário, para validar as condições do programa
            {
                Console.WriteLine("Você ganha menos que 2 sálarios minimos!");
            }
            else if (Salario < 5000)//Pode ter quantos else if for necessário, para validar as condições do programa
            {
                Console.WriteLine("Você ganha menos que 5 sálarios minimos!");
            }
            else//o else é opcional, mas é recomendado para tratar os casos que não se encaixam nas condições anteriores
            {
                Console.WriteLine("Você ganha mais que 5 sálarios minimos! VOCE É RICO ");
            }


            Console.WriteLine("Pressione uma tecla do seu teclado");
            char tecla = Console.ReadKey(true).KeyChar;
            //switch(comutador)
            switch (tecla) //variaveis
            {
                case 'a': //valores // caso
                    Console.WriteLine("VocÊ pressionou a tecla a");
                    break; //pare
                case 'b': //valores // caso
                    Console.WriteLine("Você pressionou a tecla b");
                    break;//pare
                default://Padrão = opcional
                    Console.WriteLine("Eu não conheço essa tecla");
                    break;//pare
            }
            Console.ReadKey();
        }
    }
}

