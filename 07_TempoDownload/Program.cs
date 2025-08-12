using System;
using System.Globalization;

namespace _07_TempoDownload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tamanho;
            double velocidade;

            tamanho = ObterValor("Informe o tamanho do arquivo (MB): ");
            velocidade = ObterValor("Informe a velocidade da internet (Mbps): ");

            double tempoSegundos = (tamanho * 8) / velocidade;
            double tempoMinutos = tempoSegundos / 60;

            Console.WriteLine($"Tempo aproximado de download: {tempoMinutos.ToString("F2", CultureInfo.InvariantCulture)} minutos");

            Console.ReadKey();
        }
 
        static double ObterValor(string mensagem)
        {
            double valor;
            while (true)
            {
                Console.Write(mensagem);
                string entrada = Console.ReadLine();

                if (double.TryParse(entrada, NumberStyles.Any, CultureInfo.InvariantCulture, out valor) && valor > 0)
                {
                    return valor;
                }
                else
                {
                    Console.WriteLine("Valor inválido! Digite um número maior que zero.");
                }
            }
        }
    }
}