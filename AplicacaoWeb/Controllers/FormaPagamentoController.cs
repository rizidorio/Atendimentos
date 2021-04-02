using AplicacaoWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoWeb.Controllers
{
    public class FormaPagamentoController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Salvar(FormaPagamento formaPagamento)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using var client = new HttpClient();

                    var formaPagamentoJson = JsonConvert.SerializeObject(formaPagamento);
                    var content = new StringContent(formaPagamentoJson, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(Program.formaPagamentoApi, content);

                    TempData["Error"] = string.Empty;

                    if (result.IsSuccessStatusCode)
                        return RedirectToAction("FormaPagamento", "Financeiro");
                    else
                    {
                        TempData["Error"] = result.Content.ReadAsStringAsync().Result;
                        return View("../Financeiro/NovaFormaPagamento");
                    }
                }
                else
                {
                    return View("../Financeiro/NovaFormaPagamento");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Atualizar(FormaPagamento formaPagamento)
        {
            if (ModelState.IsValid)
            {
                using var client = new HttpClient();

                var formaPagamentoJson = JsonConvert.SerializeObject(formaPagamento);
                var content = new StringContent(formaPagamentoJson, Encoding.UTF8, "application/json");
                var result = await client.PutAsync(Program.formaPagamentoApi, content);

                TempData["Error"] = string.Empty;

                if (result.IsSuccessStatusCode)
                    return RedirectToAction("FormaPagamento", "Financeiro");
                else
                {
                    TempData["Error"] = result.Content.ReadAsStringAsync().Result;
                    return View("../Financeiro/EditarFormaPagamento");
                }
            }
            else
            {
                return View("../Financeiro/EditarFormaPagamento");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Remover(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                using var client = new HttpClient();

                var result = await client.DeleteAsync($"{Program.formaPagamentoApi}/{id}");   
            }

            return RedirectToAction("FormaPagamento", "Financeiro");
        }
    }
}
