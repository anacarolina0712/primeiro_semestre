using System;

namespace projeto_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o primeiro numero:")
            String num1_texto = Console.ReadLine();
            int num1 = int.Parse(num1_texto);

            Console.WriteLine("digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int soma = num1 + num2;
          
            //Console.Write(" o resultado é: ")
            //console.writeline(soma);

            Console.WriteLine("o resultado de " + num1 + " + " + num2 + " é: " + soma);
        }
    }
}
