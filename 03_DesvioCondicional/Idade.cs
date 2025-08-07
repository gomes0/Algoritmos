using System;

class ClassificacaoIdade
{
    static void Main()
    {
		Console.WriteLine("Digite sua idade: ");
		int idade = int.Parse(Console.ReadLine());
		
		if(idade <= 12) 
		{
			Console.WriteLine("Você é Criança");
		}
		else if (idade <= 17)
		{
			Console.WriteLine("Você é Adolescente");
		}	
		else
		{
			Console.WriteLine("Você é Adulto");
		}
    }
}