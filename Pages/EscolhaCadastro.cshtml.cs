    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Eco_life.Models;

    namespace Eco_life.Pages
    {
        public class EscolhaCadastroModel : PageModel
        {
            private readonly ApplicationDbContext _context;

            public EscolhaCadastroModel(ApplicationDbContext context)
            {
                _context = context;
            }

            [BindProperty]
            public EscolhaUsuario Escolha { get; set; } = new EscolhaUsuario();

            public IActionResult OnPost()
            {
                if (Escolha.TipoCadastro == "Usuario")
                {
                    return RedirectToPage("/CadastrarUsuario");
                }
                else if (Escolha.TipoCadastro == "Fornecedor")
                {
                    return RedirectToPage("/CadastrarFornecedor");
                }

                return Page();
            }
        }
    }
