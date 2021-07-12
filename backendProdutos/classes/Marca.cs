using System;
using System.Collections.Generic;

namespace backend_UltimoProjetoDoAno_21_12.classes
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string Nomemarca { get; set; }
        public DateTime datacadastro { get; set; }
        public List<Marca> listademarcas = new List<Marca>();
        public Marca Cadastrar(){

            Marca novaMarca = new Marca();

            Console.WriteLine("Digite o codigo da marca: ");
            novaMarca.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o nome da marca:");
            novaMarca.Nomemarca = Console.ReadLine();

            datacadastro = DateTime.UtcNow;

            listademarcas.Add(novaMarca);

            return novaMarca;

        }

        public void Listar()
        {

            Console.ForegroundColor = ConsoleColor.Magenta;

            foreach (Marca item in listademarcas)
            {
                System.Console.WriteLine($"codigo: {item.Codigo}");
                System.Console.WriteLine($"Marca: {item.Nomemarca}");
                System.Console.WriteLine($"data do cadastro: {item.datacadastro}");
            }

            Console.ResetColor();

        }

        public void Deletar (int codigo){

            Marca MarcasDelete = listademarcas.Find(m => m.Codigo == codigo);
            listademarcas.Remove(MarcasDelete);
        }
    }

}