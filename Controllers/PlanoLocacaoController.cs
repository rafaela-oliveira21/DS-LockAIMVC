using Microsoft.AspNetCore.Mvc;
using PropostaLocacaoFront.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace PropostaLocacaoFront.Controllers
{
    public class PropostaLocacaoController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly string apiUrl = "https://sua-api.com/api/PropostaLocacao"; // Substitua pela URL real

        public PropostaLocacaoController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index()
        {
            var propostas = await _httpClient.GetFromJsonAsync<List<PropostaLocacao>>(apiUrl);
            return View(propostas);
        }
    }
}
