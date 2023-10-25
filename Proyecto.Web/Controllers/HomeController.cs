using Proyecto.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Proyecto.Domain.InputModels.Cliente;
using Proyecto.Application.Contracts;

namespace Proyecto.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IClienteService _service;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
		public ActionResult Registro()
		{
			return View(new NuevoCliente());
		}

        [HttpPost]
        public IActionResult RegistrarUsuario(NuevoCliente newCliente)
        {
            if (ModelState.IsValid)
            {
                if (!_service.Insert(newCliente))
                {
                    ModelState.AddModelError(string.Empty, "Cliente no pudo ser ingresado");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            return View(newCliente);
        }

        public IActionResult Index()
        {
            return View();
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