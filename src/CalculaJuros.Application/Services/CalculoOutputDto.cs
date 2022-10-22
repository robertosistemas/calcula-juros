namespace CalculaJuros.Application.Services
{
    public class CalculoOutputDto
    {
        public double Resultado { get; private set; }

        public CalculoOutputDto(double resultado)
        {
            Resultado = resultado;
        }

        public override string ToString()
        {
            return Resultado.ToString("###########0.00");
        }
    }
}
