using Microsoft.AspNetCore.Mvc;
using Panaderia.Models;

namespace Panaderia.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Lista()
        {
            return View();
        }

        public IActionResult Ver(int id)
        {

            return View();
        }
    }
}