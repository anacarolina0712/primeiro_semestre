using System;

namespace backend_métodosConstrutores.classes
{
    public class pessoas
    {
        public string primeironome;
        public string sobrenome;

        public pessoas(string primeironome, string sobrenome){
            Console.WriteLine($"Bem vindo {primeironome} {sobrenome}");
        }

        

    }
}