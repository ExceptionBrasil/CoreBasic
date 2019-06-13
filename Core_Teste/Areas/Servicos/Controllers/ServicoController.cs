using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Core_Teste.Areas.Servicos.Controllers
{
    public class ServicoController : Controller
    {
        [Area("Servicos")]
        public IActionResult Index()
        {
            return View();
        }
    }
}