using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao.Controllers
{
    public class PainelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Financeiro()
        {
            return View();
        }
    }
}
