using System;

namespace backend_calculosalario
{
    class Program
    {
        static void Main(string[] args)
        {
           Professor prof = new Professor();
            Console.WriteLine("olá seja bem-vindo!!");
            Console.WriteLine("Quantas horas trabalhou esse mês?");
            float horas = float.Parse(Console.ReadLine());
            prof.nome = "Carlos tsukamoto";
            
            Console.WriteLine( $" o valor do salario esse mês é : {prof.CalcSalario(horas)}");
        }

    }
}

