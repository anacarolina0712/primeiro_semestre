using System;

namespace Polimorfismo_Sobercarga.classes
{
    public class Funcionario
    {
        //sintaxe completa
        //atalho : propfull
        private int myVar;
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        //Alternativa com sintaxe reduzida:
        //atalho prop
        public string Name { get; set; }

        // RealizarPagamento
        // RealizarPagamentosemcartão(){}
        // RealizarPagamentocomcartão(string cartao){}

        // A atividade começa aqui
        private string[] lista = { "paulo", "tsuka", "ana carolina", "priscila", "fernando" };

        public void mostrar()
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        public void mostrar(int indice)
        {
            Console.WriteLine("Busca por indice :" + lista[indice]);
        }

        public void mostrar(string busca)
        {
            foreach (var item in lista)
            {
                if (item == busca)
                {
                    Console.WriteLine("resultado da busca: " + item);
                }
            }
        }



    }

}