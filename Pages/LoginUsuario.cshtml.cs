using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Eco_life.Models;
using System.Linq; // Certifique-se de ter essa diretiva para usar LINQ

namespace Eco_life.Pages
{
    public class LoginUsuarioModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public LoginUsuarioModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string? Email_User { get; set; } // Propriedade Nullable
        [BindProperty]
        public string? Senha_User { get; set; } // Propriedade Nullable

        public IActionResult OnPost()
        {
            if (string.IsNullOrEmpty(Email_User) || string.IsNullOrEmpty(Senha_User))
            {
                ModelState.AddModelError("", "Email ou senha não podem estar vazios.");
                return Page();
            }

            var usuario = _context.Cadastros
                .FirstOrDefault(u => u.Email_User == Email_User && u.Senha_User == Senha_User);

            if (usuario != null)
            {
                // Autenticação bem-sucedida
                return RedirectToPage("/Index");
            }

            // Falha na autenticação
            ModelState.AddModelError("", "Email ou senha inválidos.");
            return Page();
        }
    }
}
