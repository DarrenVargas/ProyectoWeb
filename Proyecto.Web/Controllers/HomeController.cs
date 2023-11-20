using Proyecto.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Proyecto.Domain.InputModels.Cliente;
using Proyecto.Application.Contracts;

namespace Proyecto.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}