using System.IO;

namespace EPLAYERS_MVC.Models
{
    public class EPlayersBase
    {
        public void CreateFolderAndFile(string path)
        {
            
            // DataBase/Equipe.csv
            string folder = path.Split("/")[0];
            
            if(!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if(!File.Exists(path))
            {
                File.Create(path);
            }
        }

        public List<String> ReadAllLinesCSV(String path)
        {
            // using -> abrir e fechar determinado tipo de arquivo ou conexão
            // streamReader -> ler as informações do meu csv 
            using (StreamReader file = new StreamReader (path))
            {
                string linha;
                while((linha = file.ReadLine()) != null)
                {
                    linhas.Add(linha);
                }
            }

            return linha;
        }
        



    }
}