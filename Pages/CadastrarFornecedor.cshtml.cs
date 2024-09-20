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
        public Funcionario1 Fornecedor1 { get; set; } = new Funcionario1();

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Gere o token e atribua ao Fornecedor1
            Fornecedor1.Token = TokenGenerator.GenerateToken();

            // Adicione o Fornecedor1 ao contexto
            _context.Funcionarios1.Add(Fornecedor1);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}
