using Guests.Application.Contracts;
using Guests.Domain.InputModels.Guests;
using Microsoft.AspNetCore.Mvc;

namespace Guests.Web.Controllers
{
    public class GuestsController : Controller
    {
        private readonly IGuestService _service;

        public GuestsController(IGuestService service)
        {
            this._service = service;
        }

        public IActionResult Index()
        {
            var guests = _service.List();
            return View(guests);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View(new NewGuest());
        }

        [HttpPost]
        public IActionResult Insert(NewGuest newGuest)
        {
            if (ModelState.IsValid)
            {
                if (!_service.Insert(newGuest))
                {
                    ModelState.AddModelError(string.Empty, "Guest could not be inserted");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            return View(newGuest);
        }
            
        [HttpDelete]
        [Route("/api/v1/guests/delete/{id}")]
        public JsonResult Delete([FromRoute]int id)
        {
            if (_service.Delete(id))
            {
                return Json(new { success = true });
            }

            return Json(new { success = false, errorMessage = "Guest could not be deleted."});
        }
    }
}
