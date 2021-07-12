using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] produtos = {"maça", "batata", "cenoura"};
            double[] preços = {1.1, 2.3, 4.5};
            int[] idades = {16, 17, 17};

            string[] nomesAlunos = new string[5];

            // console.writeline(produtos[1]);

            // console.writeline("trocar batata por qua item: );
            // produtos[1] = console.readline[1]);
            // console.writeline(produtos.length);

            for (int i = 0; i < produtos.Length; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(produtos[i]);
            }
        }
    }
}
