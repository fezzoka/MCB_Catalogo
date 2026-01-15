using MCB_Catalogo.Data;
using MCB_Catalogo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MCB_Catalogo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var produtos = _context.Produtos.ToList();
            return View(produtos);
        }
    }
}