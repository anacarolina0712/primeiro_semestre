using System;
using System.Collections.Generic;

namespace backend_UltimoProjetoDoAno_21_12.classes
{
    public class Produto
    {
        public int codigo { get; set; }
        public string NomeProduto { get; set; }
        public float preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca marca = new Marca();
        public Usuario Usuario = new Usuario ();

        public List<Produto> ListaProdutos = new List<Produto>();


        public void Cadastrar(){
            
           Produto novoProduto = new Produto();

           System.Console.WriteLine($"Digite o código do Produto: ");
           novoProduto.codigo = int.Parse(Console.ReadLine());

         
           Console.WriteLine($"Digite o nome do Produto: ");
           novoProduto.NomeProduto = Console.ReadLine();

            Console.WriteLine($"Digite o nome do Produto: ");
            novoProduto.preco = float.Parse(Console.ReadLine());

            // Chamamos um método do objeto/propriedade "marca"
            novoProduto.marca = marca.Cadastrar();

        
            // Utilizamos o próprio método construtor para atribuir um objeto completo de usuário
      
            ListaProdutos.Add(novoProduto);

        }

        public void Listar(){
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (Produto item in ListaProdutos)
            {
                Console.WriteLine($"Codigo: {item.codigo}");
                Console.WriteLine($"Produto: {item.NomeProduto}");
                Console.WriteLine($"preco: {item.preco}");
                Console.WriteLine($"Data do Cadastro: {item.DataCadastro}");
                Console.WriteLine($"Marca: {item.marca.Nomemarca}");
                Console.WriteLine($"Cadatrado porr:  {item.Usuario.Nome}");
            }

            Console.ResetColor();

        }

        public void Deletar(int cod){

            Produto prodDelete = ListaProdutos.Find(p => p.codigo == cod);
            ListaProdutos.Remove(prodDelete);
        }
        
        
        
        
        
        
        
        
        
        
        
        
    }
}