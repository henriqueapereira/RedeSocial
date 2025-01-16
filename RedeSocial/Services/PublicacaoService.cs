using RedeSocial.Models;
using System.Net.Http.Json;

public class PublicacaoService
{
    private readonly HttpClient _httpClient;

    public PublicacaoService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Publicacao>> GetPublicacoesAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<Publicacao>>("api/publicacoes");
    }
}

