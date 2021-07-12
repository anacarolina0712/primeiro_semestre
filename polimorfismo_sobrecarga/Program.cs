using System;
using Polimorfismo_Sobercarga.classes;

namespace Polimorfismo_Sobercarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun = new Funcionario();
            fun.mostrar();
            fun.mostrar("ana carolina");
            fun.mostrar(2);

            Console.Beep();
        }
    }
}
