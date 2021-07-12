using System;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Digite o primeiro número:");
            string num1_text = Console.ReadLine();
            int num1 = int.Parse(num1_text);

            Console.WriteLine("Digite o segundo número:");
            int num2 = int.Parse(Console.ReadLine());

            int soma = num1 + num2;

            Console.Write("O resultado é: ");
            Console.WriteLine(soma);
        }
    }
}
