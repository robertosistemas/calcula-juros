using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculaJuros.Web.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Para entrar em contato com desenvolvedor.";
        }
    }
}
