using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoWeb.Controllers
{
    public class OutrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
