using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Eco_life.Models;
using Microsoft.EntityFrameworkCore;

namespace Eco_life.Pages
{
    public class LojaModel : PageModel
    {
        private readonly ILogger<LojaModel> _logger;
        private readonly ApplicationDbContext _context;

        public LojaModel(ILogger<LojaModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IList<Produtos> Produtos { get; set; } = new List<Produtos>();

        public async Task OnGetAsync()
        {
            Produtos = await _context.Produtos.ToListAsync();
        }
    }
}
