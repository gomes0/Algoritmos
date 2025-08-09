using System;

namespace _06_Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite o número:");

            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Tabuada do {numero}");
            int resultado;

            for (int i = 0; i <= 10; i++)
            {
                 resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
        }
    }
}