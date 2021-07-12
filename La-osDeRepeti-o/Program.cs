using System;

namespace cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
           string nome;
           int idade;
           double salario;
            char estadoCivil;

            do
            {
                Console.WriteLine("Digite seu nome: ");
                nome = Console.ReadLine();
            } while(nome == "" || nome == " ");

            do
            {
                Console.WriteLine("Digite sua idade: ");
                idade = int.Parse( Console.ReadLine());
            } while(idade <= 0 || idade > 150);

            do
            { 
                Console.WriteLine("Digite seu salário: ");
                salario = double.Parse(Console.ReadLine());
            } while(!(salario > 0));

            do
            {
                Console.WriteLine("Digite seu estado civil:  's'solteiro(a)); 'c'casado(a)); 'v'viuvo(a)); 'd'divorciado(a)); ");
                estadoCivil = Console.ReadLine().ToCharArray()[0];
            } while (estadoCivil != 's' && estadoCivil != 'c' && estadoCivil != 'v' && estadoCivil != 'd' );

                Console.WriteLine("valores aceitos");
        }
    }
}
