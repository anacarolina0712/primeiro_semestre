using System;

namespace condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            // para participar do time de cs o aluno precisa ter média maior ou igual a 80
            //e fltas menor igual a 10% dos dias letivos.
            Console.WriteLine("Bem vindo a seletiva para o time counter strike");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("você gostaria de participar? sim ou não?");
            string resposta = Console.ReadLine();
            if (resposta == "sim")
            {
                Console.WriteLine("Que legal! agora vamos analisar seu curriculo");
                Console.WriteLine("insira sua média escolar?");
                int Media = int.Parse(Console.ReadLine());
                Console.WriteLine("qual é o seu numero de faltas");
                int notas = int.Parse(Console.ReadLine());
                if (Media >= 8 && notas<= 10)
                {
                    Console.WriteLine("Parabéns,Seja Bem vindo!");
                }
                else
                {
                    Console.WriteLine("poxa, seus requisitos são insuficientes.");
                }
            }
        }
    }
}


