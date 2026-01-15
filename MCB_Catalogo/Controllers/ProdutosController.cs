using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MCB_Catalogo.Data;
using MCB_Catalogo.Models;

namespace MCB_Catalogo.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProdutosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Isso agora funcionará após o passo 4
            return View(await _context.Produtos.ToListAsync());
        }
    }
}