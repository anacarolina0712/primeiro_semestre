using System;
using System.Collections.Generic;
using MVC_console_05_01_2021.Models;

namespace MVC_console_05_01_2021.Views
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produto)
        {
            foreach(var item in produto)
            {
                Console.WriteLine ($"Código : {item.Codigo}");
                Console.WriteLine ($"Produto : {item.Nome}");
                Console.WriteLine ($"Preço : R$ {item.Preco}");
                Console.WriteLine("");
            }
        }

        public void CadatrarProduto()
        {

            Produto produto = new Produto();

            Console.WriteLine($"Digite um codigo:");
            produto.Codigo = int.Parse( Console.ReadLine() );
            
            Console.WriteLine($"Digite um nome para o produto:");
            produto.Nome = Console.ReadLine();

            Console.WriteLine($"Digite o preço do produto:");
            produto.Preco = float.Parse(Console.ReadLine() );
            
            
        }
    }
}