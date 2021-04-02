using AplicacaoWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AplicacaoWeb.Controllers
{
    public class FinanceiroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> FormaPagamento()
        {
            using var client = new HttpClient();

            using var response = await client.GetAsync(Program.formaPagamentoApi);

            if (response.IsSuccessStatusCode)
            {
                var formaPagamentoJson = await response.Content.ReadAsStringAsync();
                var formaPagamentoDeserializada = JsonConvert.DeserializeObject<FormaPagamento[]>(formaPagamentoJson).ToList();
                return View(formaPagamentoDeserializada);
            }
            else
            {
                return View();
            }
        }

        public IActionResult NovaFormaPagamento()
        {
            return View();
        }

        public async Task<IActionResult> EditarFormaPagamento(string id)
        {
            using var client = new HttpClient();

            using var response = await client.GetAsync($"{Program.formaPagamentoApi}/{id}");

            if (response.IsSuccessStatusCode)
            {
                var formaPagamentoJson = await response.Content.ReadAsStringAsync();
                var formaPagamentoDeserializada = JsonConvert.DeserializeObject<FormaPagamento>(formaPagamentoJson);
                return View(formaPagamentoDeserializada);
            }

            return View();
        }
    }
}
