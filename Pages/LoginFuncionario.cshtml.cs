using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Eco_life.Models;

namespace Eco_life.Pages
{
    public class LoginFuncionarioModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public LoginFuncionarioModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string? Email_Funcionario { get; set; }
        [BindProperty]
        public string? Senha_Funcionario { get; set; }

        public IActionResult OnPost()
        {
            // Lógica de autenticação para Funcionário
            // Exemplo:
            var funcionario = _context.Funcionarios
                .FirstOrDefault(f => f.Email_Funcionario == Email_Funcionario && f.Senha_Funcionario == Senha_Funcionario);

            if (funcionario != null)
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
