using System.Collections.Generic;
using System.IO;
using EPLAYERS_MVC.Interfaces;

namespace EPLAYERS_MVC.Models
{
    public class Equipe : EPlayersBase , IEquipe
    {
        // ID - Identificador único
        public int IdEquipe {get; set;}
        public string Nome { get; set; }
        public string Imagem { get; set; }


        private const string PATH = "DataBase/Equipe.csv";

        public Equipe()
        {
            CreateFolderAndFile(PATH);   
        }

        public string Prepare(Equipe e)
        {
           return $"(e.IdEquipe);(e.Nome);(e.Imagem)"; 
        }


        public void Create(Equipe e)
        {
            string[] linhas = { Prepare (e) };
            File.AppendAllLines(PATH, linhas);
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Equipe> ReadAll()
        {
            List<Equipe> equipes = new List<Equipe>();
            // Ler todas as linhas do CSV
            string[] linhas = File.ReadAllLines(PATH);

            // percorrer as linhas e adicionar na linha de equipes cada objeto equipe
            foreach (var item in linhas)
            {
                // 1,vivokeyd;vivo.jpg
                string[] linha = item.Split(";");

                // [0] = 1
                // [1] = vivokeyd
                // [2] = vivo.jpg

                // criamos o objeto equipe 
                Equipe equipe = new Equipe();

                // alimentamos o objeto equipe
                equipe.IdEquipe = int.Parse( linha [0] );
                equipe.Nome     = linha[1];
                equipe.Imagem   = linha[2];

                // adicionamos a equipe na linha de equipes 
                equipes.Add(equipe);
            }


            return equipes;
        }

        public void Update(Equipe e)
        {
            
            throw new System.NotImplementedException();
        }
    }
}