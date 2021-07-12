using System;

namespace projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Receber a idade da pessoa
            // Mostrar a idade da pessoa em meses, dias, horas e minutos

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Bem vindo ao calculador de idade");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Qual a sua idade?");
            
            int idade = int.Parse(Console.ReadLine());

            int meses = idade * 12;
            int dias = meses * 360;
            int horas = dias * 24;
            int minutos = horas * 60;

            Console.WriteLine("Seu tempo de vida atual é:" + meses + "meses, ")

        }
    }
}
