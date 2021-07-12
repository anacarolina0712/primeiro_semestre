using System.Collections.Generic;
using MVC_console_05_01_2021.Models;
using MVC_console_05_01_2021.Views;

namespace MVC_console_05_01_2021.Controllers
{
    public class ProdutoController
    {
        // models
        Produto produto = new Produto();
        
        // Views
        ProdutoView ProdutoView = new ProdutoView();

        public void ListarProdutos()
        {
           // List<Produto> produtos = produto.Ler();
          ProdutoView.Listar(produto.Ler());
        } 

    }
}