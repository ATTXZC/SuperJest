using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Eco_life.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eco_life.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _context;

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
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
