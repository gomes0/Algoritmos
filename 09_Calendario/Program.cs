using System;
using System.Linq;

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

            //int[] diasFeriados = { };
            int[] diasFeriados = RetornaFeriados(mes, ano);
            //impressão do calendário
            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                {
                    if (calendario[semana, diaSemana] != 0)
                    {
                        if (diasFeriados.Contains(calendario[semana, diaSemana]) || diaSemana == 0)
                            Console.ForegroundColor = ConsoleColor.Red;

                        Console.Write(calendario[semana, diaSemana].ToString("D2") + "\t");

                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }

            Console.Write("\nFeriados: ");
            for (int i = 0; i < diasFeriados.Length; i++)
            {
                if (diasFeriados[i] > 0)
                {
                    Console.Write($"{diasFeriados[i].ToString("D2")}\t");
                }
            }

            //Espera o usuário teclar qualquer tecla
            Console.ReadKey();


        }

        public static int[] RetornaFeriados(int mes, int ano)
        {
            int[] feriados = new int[15];

            int indice = 0;
            //feriados[indice] = 11;
            //indice = indice + 1;
            //feriados[indice++] = 11;
            //feriados[indice++] = 21;
            if (mes == 1) feriados[indice++] = 1;
            else if (mes == 4)
            {
                feriados[indice++] = 4;
                feriados[indice++] = 21;
            }
            else if (mes == 5) feriados[indice++] = 1;
            else if (mes == 7) feriados[indice++] = 9;
            else if (mes == 9) feriados[indice++] = 7;
            else if (mes == 10) feriados[indice++] = 12;
            else if (mes == 11)
            {
                feriados[indice++] = 2;
                feriados[indice++] = 15;
                feriados[indice++] = 20;
            }
            else if (mes == 12)
            {
                feriados[indice++] = 8;
                feriados[indice++] = 25;
            }
            return feriados;
        }
    }
}