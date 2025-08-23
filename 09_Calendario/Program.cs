using System;
using System.Globalization;

namespace _09_Calendario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //gera o primeiro dia do mês e ano informado pelo usuário

            Console.Write("Digite o mês (1-12): ");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("Digite o ano: ");
            int ano = int.Parse(Console.ReadLine());

            //descobre a quantidade de dias de um mês
            int diasDoMes = DateTime.DaysInMonth(ano, mes);

            //descobre o dia da semana do primeiro dia do mês
            // 0 = Domingo - 6 Sábado

            DateTime primeiroDiaMes = new DateTime(ano, mes, 1);
            int diaSemanaInicio = (int)primeiroDiaMes.DayOfWeek;

            //matriz de 6 semanas e 7 dias
            int[,] calendario = new int[6, 7];

            int dia = 1;

            //preenche a matriz com os dias do mês
            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                {
                    if ((semana == 0 && diaSemana < diaSemanaInicio) || dia > diasDoMes)
                    {
                        calendario[semana, diaSemana] = 0;
                    }
                    else
                    {
                        calendario[semana, diaSemana] = dia;
                        dia++;
                    }
                }
            }

            Console.WriteLine($"\nCalendário de " +
                $"{primeiroDiaMes.ToString("MMMM")} de {ano}");

            Console.WriteLine("DOM\tSEG\tTER\tQUA\tQUI\tSEX\tSAB");

            //impressão do calendário
            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                {
                    if (calendario[semana, diaSemana] != 0)
                    {
                        Console.Write(calendario[semana, diaSemana].ToString("D2") + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}