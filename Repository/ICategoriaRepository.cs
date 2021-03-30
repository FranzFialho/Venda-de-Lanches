 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanchesFF.Models;

namespace LanchesFF.Repository
{
    public interface ICategoriaRepository
    {

        IEnumerable<Categoria> Categorias { get; }


    }
}
