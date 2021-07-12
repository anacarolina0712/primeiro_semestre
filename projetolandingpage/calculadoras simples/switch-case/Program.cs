using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)

        {
            //perguntar a operação
            Console.WriteLine("qual operação deseja realizar? \nsoma, subtraçao, multiplicaçao, divisao");
            string operação = Console.ReadLine().ToLower();

            //pedir o 1° numero;
            Console.WriteLine("digite o 1° número :");
            float num1 = float.Parse( Console.ReadLine() );

            //pedir o 2° número
            Console.WriteLine("digite o 2° numero :");
            float num2 = float.Parse( Console.ReadLine() );

            //fazer o cálculo
            // f = sufixo do float
            float resultado = 0f;
            
            switch(operação){
                
                case "soma":
                resultado = num1 - num2;
                break;

                case "subtração":
                resultado = num1 = num2;
                break;
                
                case "multipliçao":
                resultado = num1 * num2;
                break;
                
                case "divisao":
                resultado = num1 / num2;
                break;
            
            default: 
            Console.WriteLine("operação inválida :( ");
            break;
            
            }

            // mostrar o resultado

            // concatenação
            // console.writeline("calculo : "+ num1 +" com "+ num2 +" = resultado)

            //interpolação;
            Console.WriteLine($"calculo : {num1} com {num2} = {resultado}");
            
        }
    }
}
