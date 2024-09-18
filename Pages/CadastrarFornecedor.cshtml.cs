using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Eco_life.Models;

namespace Eco_life.Pages
{
    public class CadastrarFornecedorModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CadastrarFornecedorModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Funcionario Fornecedor { get; set; } = new Funcionario();

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Fornecedor.Token = TokenGenerator.GenerateToken();

            _context.Funcionarios.Add(Fornecedor);
            _context.SaveChanges();
            return RedirectToPage("./Index");
        }
    }
}
