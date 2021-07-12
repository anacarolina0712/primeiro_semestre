using System;

namespace POO_14_12
{
    class Program
    {

        static void Main(string[] args)
        {
            // classes estáticas não podem ser instanciadas 

            // em que momento usamos classes estáticas?
            // quando precisarmos de uma soluçõo que pode servir 
            // para qualquer tipo de aplicação

            //em que momento não usamos classes estáticas?
            // quando tivermos objetos/classes que são especificas de um tipo de aplicação

            Console.WriteLine( Math.Pow(2, 5) );

            Console.WriteLine("digite um valor: ");
            Conversor.valorUsuario = float.Parse( Console.ReadLine() );
            
            Console.WriteLine("digite qual conversao voce deseja realizar: ");
            string conversao = Console.ReadLine();
            
            if (conversao == "euro")
            {
                Console.WriteLine(Conversor.converterRealParaEuro());
            }

            if (conversao == "real/dolar")
            {
                Console.WriteLine( Conversor.conversorDolarParaReal() );
            }

            if (conversao == "dolar")
            { 
                Console.WriteLine(Conversor.converterRealParaDolar() );
            }
            
               if (conversao == "real/euro")
            {
                Console.WriteLine ( Conversor.conversorEuroparaReal());
            }
            
            //este método tbm tem que ser static na sua declaração
            Testar();
        }

        static void Testar()
        {

        }

    }
}

