using LanchesFF.Context;
using LanchesFF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LanchesFF.Repository
{
    public class LancheRepository : ILancheRepository
    {
      

        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categorias);
        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(p =>
        p.IsLanchePreferido).Include(c => c.Categorias);

        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(L => L.LancheId == lancheId);
        }

    }
}
