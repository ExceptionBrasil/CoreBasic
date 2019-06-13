using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Core_Teste.Areas.Produtos.Controllers
{
    public class ProdutoController : Controller
    {
        [Area("Produtos")]
        public IActionResult Index()
        {
            return View();
        }
    }
}