using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculaJuros.Web.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Sistema para cálculo de juros compostos.";
        }
    }
}
