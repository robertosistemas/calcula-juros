using System.ComponentModel.DataAnnotations;

namespace CalculaJuros.Web.ViewModels
{
    public class CalculoViewModel
    {
        [Display(Name = "Valor Inicial", Prompt = "Valor Inicial")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Digite o valor inicial!")]
        public double? ValorInicial { get; set; }

        [Display(Name = "Mêses", Prompt = "Quantidade de mêses")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Digite a quantidade de mêses!")]
        public int? Meses { get; set; }

        public string Resultado { get; set; }
    }
}
