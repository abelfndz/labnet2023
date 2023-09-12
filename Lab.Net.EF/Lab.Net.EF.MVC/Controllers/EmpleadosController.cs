using Lab.Net.EF.Logic.Empleado;
using Lab.Net.EF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Net.EF.MVC.Controllers
{
    public class EmpleadosController : Controller
    {
        private EmpleadoServicio _empleadoServicio = new EmpleadoServicio();
        private EmpleadoView _empleadoVista = new EmpleadoView();

        public ActionResult Index(string cadenaBuscar = "")
        {
            var empleadosDtos = _empleadoServicio.GetAll(cadenaBuscar);
            var empleadoViews = empleadosDtos.Select(x => new EmpleadoView()
            {
                Id = (int)x.Id,
                Apellido = x.Apellido,
                Nombre = x.Nombre,
            });

            return View(empleadoViews);
        }




        public ActionResult InsertarModificar(int? id)
        {
            if (id == null)
            {
                return View("InsertarModificar", new EmpleadoView());
            }
            else
            {
                var empleadoObtenido = _empleadoServicio.ObtenerId(id.Value);
                _empleadoVista.Id = empleadoObtenido.EmployeeID;
                _empleadoVista.Nombre = empleadoObtenido.FirstName;
                _empleadoVista.Apellido = empleadoObtenido.LastName;

                return View("InsertarModificar", _empleadoVista);

            }
        }


        [HttpPost]
        public ActionResult InsertarModificar(EmpleadoView modelo)
        {
            if (ModelState.IsValid)
            {

                if (modelo.Id == 0)
                {

                    var empleadoNuevo = (new EmpleadoDto
                    {
                        Nombre = modelo.Nombre,
                        Apellido = modelo.Apellido
                    });
                    _empleadoServicio.Insertar(empleadoNuevo);
                    return RedirectToAction("Index");
                }
                else
                {

                    var empleadoModificado = new EmpleadoDto
                    {
                        Id = modelo.Id,
                        Nombre = modelo.Nombre,
                        Apellido = modelo.Apellido
                    };
                    _empleadoServicio.Modificar(empleadoModificado);
                    return RedirectToAction("Index");
                }

            }
            return View("InsertarModificar");
        }

        public ActionResult Eliminar(decimal id)
        {
            try
            {
                _empleadoServicio.Eliminar(id);
                return RedirectToAction("Index");
            }
            catch (DbUpdateException)
            {

                return RedirectToAction("SinPermisos", "Error");
            }

        }

    }
}