using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanchesFF.Repository;
using LanchesFF.ViewModels;
using LanchesFF.Models;

namespace LanchesFF.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        private readonly ICategoriaRepository _categoriaRepository;

        public LancheController(ILancheRepository lancheRepository, ICategoriaRepository categoriaRepository)
        {
            _lancheRepository = lancheRepository;
            _categoriaRepository = categoriaRepository;
        }

        public IActionResult List(string categoria)
        {


            string _categoria = categoria;
            IEnumerable<Lanche> lanches;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRepository.Lanches.OrderBy(L => L.LancheId);
                categoriaAtual = "Todos os lanches.";
            }

            else
            {
                if (string.Equals("Normal", _categoria, StringComparison.OrdinalIgnoreCase))
                {
                    lanches = _lancheRepository.Lanches.Where(L =>
                    L.Categorias.CategoriaNome.Equals("Normal")).OrderBy(L => L.Nome);
                }
                else
                {
                    lanches = _lancheRepository.Lanches.Where(L =>
                   L.Categorias.CategoriaNome.Equals("Natural")).OrderBy(L => L.Nome);
                }

                categoriaAtual = _categoria;
            }

            var lancheslistViewModel = new LancheListViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual

            };

            return View(lancheslistViewModel);

        }
    }
}
