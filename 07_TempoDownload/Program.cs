using System;

namespace _07_TempoDownload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tamanho = 0;
            double velocidade = 0;
            double tempoSegundos, tempoMinutos;
            
            // Loop infinito
            while (true) 
            {
                // Operadores Lógicos
                // && -> AND (E lógico)
                // || -> OR (OU lógico)
                Console.WriteLine("Informe o tamanho do arquivo (MB): ");
                if (double.TryParse(Console.ReadLine(), out tamanho) && tamanho > 0)
                    // sai do loop
                    break;
                else
                    Console.WriteLine("Valor inválido! Digite um número maior que zero.");
            }

            while (true)
            {
                Console.WriteLine("Informe a velocidade da internet (Mbps): ");

                if (double.TryParse(Console.ReadLine(), out velocidade) && velocidade > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Valor inválido! Digite um número maior que zero.");
                }
            //Calculo do tempo
            tempoSegundos = (tamanho = 8) / velocidade;
            tempoSegundos /= tempoSegundos / 60;
            // Saída formatada
            Console.WriteLine($"Tempo aproximado de download: {tempoMinutos:F2} minutos");
        }
    }
}