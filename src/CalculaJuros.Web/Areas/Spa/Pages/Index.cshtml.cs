using CalculaJuros.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculaJuros.Web.Areas.Spa.Pages
{
    public class IndexModel : PageModel
    {

        [BindProperty]
        public CalculoViewModel Calculo { get; set; }

    }
}
