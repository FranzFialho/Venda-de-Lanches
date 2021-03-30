using System.Collections.Generic;
using LanchesFF.Models;

namespace LanchesFF.Repository
{
   public interface ILancheRepository
    {

        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
        Lanche GetLancheById(int lancheID);
    }
}
