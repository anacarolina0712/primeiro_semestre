using System;

namespace backend_laçoswhile_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("voce deseja receber bom dia? ");

            string resposta = "";
            int numeroDevezes = 0;

            do{
                //executado pelos menos uma vez
                Console.WriteLine("bom dia");

                Console.WriteLine("ainda deseja receber bom dia ");

                numeroDevezes ++;

                resposta = Console.ReadLine();

            }while(resposta == "sim");


            //while(resposta == "sim"){
            //    //executado quando condiçao é verdadeiro
            //    console.writeline("bom dia");

            //    //numerodevezes = numerodevezes +1;
            //        numeroDevezes++;

            //  console.writeline("ainda deseja receber um bom dia? ");
            //  resposta = console.readline();
            // }

            Console.WriteLine($"numero de vezes: {numeroDevezes}");
            Console.WriteLine("fim do programa");
        }
    }
}
