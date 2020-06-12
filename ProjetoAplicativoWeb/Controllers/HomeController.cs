using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoAplicativoWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cadastro() {

            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(string nome, string email) {

            if (nome != "" && email != "") {



            }

            return View();
        }
    }
}