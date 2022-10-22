using System.Globalization;

namespace CalculaJuros.Core.Tests;

public class BaseUnitTest
{
    public BaseUnitTest()
    {
        var culture = new CultureInfo("pt-BR");
        culture.NumberFormat.NumberDecimalSeparator = ",";
        culture.NumberFormat.NumberGroupSeparator = ".";
        culture.NumberFormat.CurrencyDecimalSeparator = ",";
        culture.NumberFormat.CurrencyGroupSeparator = ".";

        var UIculture = new CultureInfo("pt-BR");
        UIculture.NumberFormat.NumberDecimalSeparator = ",";
        UIculture.NumberFormat.NumberGroupSeparator = ".";
        UIculture.NumberFormat.CurrencyDecimalSeparator = ",";
        UIculture.NumberFormat.CurrencyGroupSeparator = ".";

        Thread.CurrentThread.CurrentCulture = culture;
        Thread.CurrentThread.CurrentUICulture = UIculture;
    }
}
