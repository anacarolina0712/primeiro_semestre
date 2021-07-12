using System.Collections.Generic;
using System.IO;

namespace MVC_console_05_01_2021.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        private const string PATH = "Database/Produto.csv";
        
        public Produto(){

            // verificar se a pasta existe 
            string pasta = PATH.Split("/")[0];
            // {0} Database
            // [1] Produto.csv

            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            // verificar se o arquivo existe
            if(!File.Exists(PATH))
            {
                File.Create(PATH);
            }

        }

        public List<Produto> Ler()
        {
            // crio uma lista para armazenar os produtos
            List<Produto> Produto = new List<Produto>();            

            // lemos as linhas do CSv
            string[] linhas = File.ReadAllLines(PATH);

            // percorrer as linhas do csv
            foreach (string item in linhas)
            {
                //separamos as elementos de cada linha 
                string[] atributos = item.Split(";");
                // 1;JBL;5000,00
                // [0] = 1
                // [1] = JBL
                // [2] = 5000,00

                // passamos para um objeto do tipo Produto
                Produto prod  = new Produto();
                prod.Codigo   = int.Parse( atributos[0] );
                prod.Nome     = atributos[1];
                prod.Preco    = float.Parse(atributos[2] );

                Produto.Add(prod);
            }


            return Produto;
        }

        public void Inserir(Produto produto)
        {
            
            // criamos um array de linhas para inserir no csv 
            string[] linhas = { PrepararLinhaCSV(produto) };
            // Método responsável por inserir linhas em um arquivo
            File.AppendAllLines(PATH, linhas);
        }
        public string PrepararLinhaCSV(Produto prod)
        {
            return $"{prod.Codigo};{prod.Nome};{prod.Preco}";
        }
    }
}