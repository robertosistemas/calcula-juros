using CalculaJuros.Web.Services;
using CalculaJuros.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculaJuros.Web.Areas.Mpa.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ICalculadoraHttpService _calculadoraHttpService;

        [BindProperty]
        public CalculoViewModel? Calculo { get; set; } = null;

        public bool Pesquisado { get; private set; }

        public IndexModel(ICalculadoraHttpService calculadoraHttpService)
        {
            _calculadoraHttpService = calculadoraHttpService;
        }

        public async Task OnPostAsync()
        {
            Pesquisado = true;
            Calculo.Resultado = await _calculadoraHttpService.CalcularJurosAsync(Calculo.ValorInicial.Value, Calculo.Meses.Value);
        }

    }
}
