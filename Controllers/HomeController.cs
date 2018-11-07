using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Panaderia.Context;
using Panaderia.Models;

namespace Panaderia.Controllers
{
    public class HomeController : Controller
    {
        private readonly PanaderiaContext _context;
        public HomeController(PanaderiaContext _context)
        {
            this._context = _context;
        }

        #region Contacto

        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contacto(Mensaje m)
        {
            if (ModelState.IsValid)
            {                
                _context.Add(m);
                _context.SaveChanges();

                return RedirectToAction("Confirmacion");
            }

            return View(m);
        }
        public IActionResult Confirmacion()
        {
            return View();
        }

        #endregion

        #region Empleados

        public IActionResult Empleados(string buscar) {

            var empleados = _context.Empleados.Include(e => e.Sucursal).AsQueryable();

            if(!string.IsNullOrEmpty(buscar)) 
            {
                empleados = empleados.Where(e => e.Nombres.Contains(buscar) || e.Apellidos.Contains(buscar) || e.Sucursal.Nombre.Contains(buscar));
            }

            ViewBag.buscar = buscar; // para no perder los datos (no vacio) escribe por defecto 

            return View(empleados.OrderBy(e => e.Apellidos).ToList());
        }
        public IActionResult Empleado() {

            PreCargaDeDatos();

            return View();
        }

        private void PreCargaDeDatos() {
            ViewBag.Sucursales = new SelectList(_context.Sucursales, "Id", "Nombre");
            //se borran todos los datos 
            //controlador a la vista
        }

        [HttpPost]
        public IActionResult Empleado(Empleado e) {

            if (ModelState.IsValid)
            {
                _context.Add(e);
                _context.SaveChanges();

                return RedirectToAction("EmpleadoConfirmacion");
            }

            PreCargaDeDatos();

            return View(e);
        }

        public IActionResult EmpleadoConfirmacion() {
            return View();
        }

        #endregion

        public IActionResult Index()
        {
            return View();
        }

        
    }
}
