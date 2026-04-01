using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_10_Aprofundamento_em_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2024, 6, 15);
            DateTime dataHora = new DateTime(2024, 6, 15, 14, 30, 0);

            //Podemos acessar o ano, mês, dia, hora, minuto e segundo individualmente
            Console.WriteLine($"Ano: {dataHora.Year}");
            Console.WriteLine($"Mês: {dataHora.Month}");
            Console.WriteLine($"Dia: {dataHora.Day}");
            Console.WriteLine($"Hora: {dataHora.Hour}");
            Console.WriteLine($"Minuto: {dataHora.Minute}");
            Console.WriteLine($"Segundo: {dataHora.Second}");
            Console.WriteLine($"Dia da semana: {dataHora.DayOfWeek}");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(data.ToString());
            Console.WriteLine(dataHora.ToString());

            //Pegando a data e hora atual
            DateTime dataHoraAtual = DateTime.Now;
            Console.WriteLine($"Data e hora atual: {dataHoraAtual}");
            Console.WriteLine("------------------------------------------");

            //Convertendo string para DateTime
            DateTime dataConvertida = Convert.ToDateTime("2024-12-25");
            DateTime dataHoraConvertida = Convert.ToDateTime("2024-12-25 14:10:20");
            Console.WriteLine($"Data convertida: {dataConvertida}");
            Console.WriteLine($"Data e hora convertida: {dataHoraConvertida}");
            Console.WriteLine("------------------------------------------");

            //Formatando a data e hora impressa
            Console.WriteLine(dataHoraConvertida.ToString("dd/MM/yyyy HH:mm:ss"));
            Console.WriteLine("------------------------------------------");

            //Operações com as variáveis do tipo DateTime
            DateTime dataHora2 = new DateTime(2020, 9, 27, 10, 0, 0);
            dataHora2 = dataHora2.AddDays(5); //Adiciona 5 dias
            dataHora2 = dataHora2.AddYears(2); //Adiciona 2 anos
            dataHora2 = dataHora2.AddHours(3); //Adiciona 3 horas
            dataHora2 = dataHora2.AddMonths(2); //Adiciona 2 meses
            Console.WriteLine($"Data e hora após adicionar 5 dias: {dataHora2.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Data e hora após adicionar 2 anos: {dataHora2.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Data e hora após adicionar 3 horas: {dataHora2.ToString("dd/MM/yyyy HH:mm:ss")}");
            Console.WriteLine($"Data e hora após adicionar 2 meses: {dataHora2.ToString("dd/MM/yyyy")}");

            dataHora2 = dataHora2.Add(new TimeSpan(1, 55, 30)); //Adiciona 1 hora, 55 minutos e 30 segundos
            Console.WriteLine($"Data e hora após adicionar 1 hora, 55 minutos e 30 segundos: {dataHora2.ToString("dd/MM/yyyy HH:mm:ss")}");
            Console.WriteLine("------------------------------------------");


            //Subtraindo datas
            DateTime dataHora3 = new DateTime(2024, 6, 15, 14, 30, 0);
            dataHora3 = dataHora3.Subtract(new TimeSpan(2, 20, 5)); //Subtrai 2 horas 20 minutos e 5 segundos
            Console.WriteLine($"Data e hora após subtrair 2 horas, 20 minutos e 5 segundos: {dataHora3.ToString("dd/MM/yyyy HH:mm:ss")}");

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
