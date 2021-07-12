using System;
using MVC_console_05_01_2021.Controllers;
using MVC_console_05_01_2021.Models;

namespace MVC_console_05_01_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController prod = new ProdutoController();
            prod.ListarProdutos(); 
        }
    }
}
