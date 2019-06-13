using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_Teste.DALs;
using Microsoft.AspNetCore.Mvc;

namespace Core_Teste.Controllers
{
    public class TesteController : Controller
    {       
        public TesteController(MinhaDAO dao)
        {
            this.DAO = dao;
        }

        public MinhaDAO DAO { get; private set; }

        public IActionResult Index()
        {
            ViewBag.SessionOpen = this.DAO.GetSession();
            return View();
        }
    }
}