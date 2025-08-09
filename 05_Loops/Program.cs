using System;
using System.Linq;

namespace _05_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criação de um vetor para armazenar de 100 elementos
            // string [] nomes {"Fulano","Beltrano", "Sicrano"};
            string[]nomes = new string[100];
            string continuar = "S";

            //Será meu índice para atribuição no vetor
            int contador = 0;

            //Loop while
            //Sintaxe: while( expressão booleana)
            //Método ToUpper(); converte o texto para maiúsculo
            while (continuar.ToUpper() == "S")
            {
                Console.WriteLine("Digite o {0}ª nome: ", contador+1);
                //Append; adiciona um item no vetor
                nomes[contador] = Console.ReadLine();

                //icrementar o contador
                contador++;
                Console.WriteLine("Deseja continuar? (S/N)");
                continuar = Console.ReadLine();
            }

            foreach (string str in nomes)
                // != significa diferente
                if (str != null)
                {
                    Console.WriteLine(str);
                }
        }
    }
}