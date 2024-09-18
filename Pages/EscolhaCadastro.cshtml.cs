using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Eco_life.Models;



namespace Eco_life.Pages
{
    public class CadastrarModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public CadastrarModel(ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Cadastros Cadastros { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cadastro.Add(Cadastros);
            _context.SaveChanges();
            return RedirectToPage("./Index");
        }
    }
}
