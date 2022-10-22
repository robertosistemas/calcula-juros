namespace CalculaJuros.Web.Services;

public class CalculadoraHttpService: ICalculadoraHttpService
{
    private readonly IHttpClientFactory _clientFactory;
    private readonly string _urlBase;

    /// <summary>
    /// http://robertosistemas-001-site1.itempurl.com
    /// https://localhost:44317
    /// </summary>
    /// <param name="configuration"></param>
    /// <param name="clientFactory"></param>
    public CalculadoraHttpService(IConfiguration configuration, IHttpClientFactory clientFactory)
    {
        _clientFactory = clientFactory;
        _urlBase = configuration["AppSettings:UrlBase"];
    }

    /// <summary>
    /// /CalculaJuros?valorinicial=100&meses=5
    /// </summary>
    /// <param name="valorInicial"></param>
    /// <param name="meses"></param>
    /// <returns></returns>
    public async Task<string> CalcularJurosAsync(double valorInicial, int meses)
    {
        var urlCalcularJuros = string.Concat(_urlBase, $"/calculajuros?valorinicial={valorInicial}&meses={meses}");
        return await GetResource<string>(urlCalcularJuros);
    }

    private async Task<T> GetResource<T>(string url)
    {
        T result = default(T);
        using (var request = new HttpRequestMessage(HttpMethod.Get, url))
        {
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("User-Agent", "CalculaJuros");
            using (var client = _clientFactory.CreateClient())
            {
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    if (response.IsSuccessStatusCode)
                    {
                        result = await response.Content.ReadFromJsonAsync<T>();
                    }
                }
            }
        }
        return result;
    }

}
