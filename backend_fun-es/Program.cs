using System;

namespace backend_exerciciosDefunção
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1 - Faça um programa que receba o nome e quatro notas de 10 alunos e armazene essas notas em vetores. Calcule e mostre:
                A. A Média do aluno - Função
                B. A quantidade de Aprovados (Média >=7)
                C. A quantidade de Reprovados (Méida < 7)
                D. A Média geral dos 10 alunos.
             */


            //double- tem uma maior precisão, ele também é mais pesado para renderizar

            //criar as variaveis necessárias

            string[] nomes = new string[5];
            float[] médias = new float[5];
            float[] notas = new float[4];

            //estruturas de repetição
            // laços contados
            // array.lenght = tamanho do array
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine ("Digite um  nome de aluno: ");
                nomes[i] = Console.ReadLine();
                 for (int n = 0; n < notas.Length; n++)
                {
                    Console.WriteLine($"digite a {(n+1)}° nota:" );
                    notas[n] = float.Parse( Console.ReadLine() );
                }

            }

                // calculamos a média fora do laço de notas
                médias[1] = (notas[0] + notas[1] + notas[2] + notas[3]) / 4;

            Console.ForegroundColor = ConsoleColor.Blue;
           
            // laços condicionais
            foreach(string nomeAvulso in nomes){
                Console.WriteLine(nomeAvulso);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            
            //mostramos as infos
            for (var i = 0; i < nomes.Length; i++)
            {
                //interpolação
                Console.WriteLine($"nome : {nomes[1]} médias: {médias[1]} ");
            }

            Console.ResetColor();
        }
    }
}
