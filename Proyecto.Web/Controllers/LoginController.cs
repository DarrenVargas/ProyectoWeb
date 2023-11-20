using Microsoft.AspNetCore.Mvc;
using Proyecto.Application.Contracts;
using Proyecto.Domain.InputModels.Usuarios;

namespace Proyecto.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly IUsuarioService _service;
        public LoginController(ILogger<LoginController> logger, IUsuarioService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult IniciarSesion(UsuarioExistente model)
        {
            if (ModelState.IsValid)
            {
                int userId = _service.GetUserByCredentials(model.NombreUsuario, model.PasswordUsuario);

                if (_service.IsCredentialValid(model.NombreUsuario, model.PasswordUsuario))
                {
                    HttpContext.Session.SetInt32("idUser", userId);
                    HttpContext.Session.SetString("username", model.NombreUsuario);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Credenciales inválidas. Por favor, inténtelo de nuevo.");
                }
            }
            return View("Index");
        }

        [HttpGet]
        public ActionResult Registro()
        {
            return View(new NuevoUsuario());
        }

        [HttpPost]
        public IActionResult Registro(NuevoUsuario newUsuario)
        {
            if (ModelState.IsValid)
            {
                if (!_service.Insert(newUsuario))
                {
                    ModelState.AddModelError(string.Empty, "Usuario no pudo ser ingresado");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            return View(newUsuario);
        }
    }
}

