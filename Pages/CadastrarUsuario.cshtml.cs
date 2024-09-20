using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Eco_life.Models;

namespace Eco_life.Pages
{
    public class CadastrarUsuarioModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CadastrarUsuarioModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cadastros1 Usuario { get; set; } = new Cadastros1();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            
            _context.Cadastros1.Add(Usuario);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}
