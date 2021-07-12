using System;
using System.Threading;

namespace backend_tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qual numero da tabuada voce deseja visualizar? ");
            int resposta = int.Parse(Console.ReadLine() );

            int resultado;

            for ( int contador = 0; contador <= 10; contador++)
            {
                resultado = resposta*contador;
                Console.WriteLine($"{resposta} * {contador} = {resposta}");
                Thread.Sleep(1000); 
            }
        }
    }
}
