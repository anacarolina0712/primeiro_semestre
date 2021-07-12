using System;

namespace Projeto2__Média_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2) / 2;
            
            string situaçao = "";

            Console.WriteLine("Média: " + media);

            if(media > 7) {
                situaçao = "Aprovado";
            }
            else {
                situaçao = "Reprovado";
            }

            Console.WriteLine(situaçao);
        }
    }
}
