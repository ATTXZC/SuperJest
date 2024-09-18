using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Eco_life.Models;
using System.Collections.Generic; // Necessária para IList<T>
using System.Threading.Tasks; // Necessária para async/await

namespace Eco_life.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger; // Necessária se estiver utilizando ILogger<IndexModel>
        private readonly ApplicationDbContext _context;

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
            Cadastros = new List<Cadastros>();
            Produtos = new List<Produtos>();
        }

        public IList<Cadastros> Cadastros { get; set; }
        public IList<Produtos> Produtos { get; set; }

        public async Task OnGetAsync()
        {
            Cadastros = await _context.Cadastros.ToListAsync();
            Produtos = await _context.Produtos.ToListAsync();
        }
    }
}