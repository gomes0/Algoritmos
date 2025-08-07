using System;

class ClassificacaoIdade
{
    static void Main()
    {
        Console.WriteLine("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());
        
        if (idade <= 12) 
        {
            Console.WriteLine("Você é Criança");
        }
        else if (idade <= 17)
        {
            Console.WriteLine("Você é Adolescente");
        }    
        else if (idade >= 60)
        {
            Console.WriteLine("Você é Idoso");
        }
        else // A única opção que sobrou é ser um adulto
        {
            Console.WriteLine("Você é Adulto");
        }
    }
}