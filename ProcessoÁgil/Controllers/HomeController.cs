using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProcessoÁgil.Models;

namespace ProcessoÁgil.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult InserirPessoas()
        {
            return View();
        }
        [HttpPost]
        public IActionResult InserirPessoas(Pessoa p)       
        {
            
            Cadastro.addPessoa(p);
            List<Pessoa> pessoas = Cadastro.Listar();
            ViewData["Pessoa"] = p;                
                        
            return View();           
        }
        public IActionResult ListarPessoas()
        {   
            List<Pessoa> pessoas = Cadastro.Listar();
            return View(pessoas);            
        }
        public IActionResult Index(Pessoa p)
        {
            Cadastro.addPessoa(p);
            List<Pessoa> pessoas = Cadastro.Listar();
            ViewData["Pessoa"] = p;                 
                  
            
            return View("InserirPessoas"); 
            ;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
