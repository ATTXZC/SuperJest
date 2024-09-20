using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eco_life.Pages
{
    public class EscolhaLoginModel : PageModel
    {
        public IActionResult OnPost(string TipoLogin)
        {
            if (TipoLogin == "Usuario")
            {
                return RedirectToPage("/LoginUsuario");
            }
            else if (TipoLogin == "Funcionario")
            {
                return RedirectToPage("/LoginFuncionario");
            }

            return Page();
        }
    }
}