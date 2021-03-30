using LanchesFF.Context;
using LanchesFF.Models;
using System;
using System.Collections.Generic;

namespace LanchesFF.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;


    }
}
