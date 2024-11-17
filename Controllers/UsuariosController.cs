using Microsoft.AspNetCore.Mvc;
using ValidacionPersonalizada.Models;

namespace ValidacionPersonalizada.Controllers
{
    public class UsuariosController : Controller
    {
        public JsonResult ValidarEmail(string email)
        {
            bool emailExistente = false;

            if (email == "text@infotoolssv.com")
            {
                emailExistente = true;
            }

            return Json(!emailExistente);
        }

        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registrar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Mensaje = "Usuario registrado con éxito.";
                return View();
            }
            else
                return View(usuario);
        }
    }
}