using Microsoft.AspNetCore.Mvc;
using Proyecto.Application.Contracts;
using Proyecto.Domain.InputModels.Usuarios;

namespace Proyecto.Web.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioService _service;

        public UsuariosController(IUsuarioService service)
        {
            this._service = service;
        }

        public IActionResult Index()
        {
            var users = _service.List();
            return View(users);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View(new NuevoUsuario());
        }

        [HttpPost]
        public IActionResult Insert(NuevoUsuario newUser)
        {
            if (ModelState.IsValid)
            {
                if (!_service.Insert(newUser))
                {
                    ModelState.AddModelError(string.Empty, "Usuario no pudo ser ingresado");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            return View(newUser);
        }

        [HttpDelete]
        [Route("/api/v1/usuarios/delete/{id}")]
        public JsonResult Delete([FromRoute] int id)
        {
            if (_service.Delete(id))
            {
                return Json(new { success = true });
            }

            return Json(new { success = false, errorMessage = "Usuario no pudo ser eliminado" });
        }
    }
}
