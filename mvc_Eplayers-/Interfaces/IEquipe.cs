using System.Collections.Generic;
using EPLAYERS_MVC.Models;

namespace EPLAYERS_MVC.Interfaces
{
    public interface IEquipe
    {
         // CRUD
         void Create(Equipe e);
         List<Equipe> ReadAll();
        void Update(Equipe e);
        void Delete(int id);

    }
}