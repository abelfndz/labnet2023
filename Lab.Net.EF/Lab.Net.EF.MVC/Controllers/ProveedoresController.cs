using Lab.Net.EF.Logic.Empleado;
using Lab.Net.EF.Logic.Proveedor;
using Lab.Net.EF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Net.EF.MVC.Controllers
{
    public class ProveedoresController : Controller
    {
        private ProveedorServicio _proveedorServicio = new ProveedorServicio();
        private ProveedorView _proveedorVista = new ProveedorView();

        public ActionResult Index(string cadenaBuscar = "")
        {
            var proveedorDtos = _proveedorServicio.GetAll(cadenaBuscar);
            var proveedorViews = proveedorDtos.Select(x => new ProveedorView()
            {
                Id = (int)x.Id,
                NombreCompania = x.NombreCompania,
                Ciudad = x.Ciudad,
            });

            return View(proveedorViews);
        }




        public ActionResult InsertarModificar(int? id)
        {
            if (id == null)
            {
                return View("InsertarModificar", new ProveedorView());
            }
            else
            {
                var proveedorObtenido = _proveedorServicio.ObtenerId(id.Value);
                _proveedorVista.Id = proveedorObtenido.SupplierID;
                _proveedorVista.NombreCompania = proveedorObtenido.CompanyName;
                _proveedorVista.Ciudad = proveedorObtenido.City;

                return View("InsertarModificar", _proveedorVista);

            }
        }


        [HttpPost]
        public ActionResult InsertarModificar(ProveedorView modelo)
        {
            if (ModelState.IsValid)
            {

                if (modelo.Id == 0)
                {

                    var proveedorNuevo = (new ProveedorDto
                    {
                        NombreCompania = modelo.NombreCompania,
                        Ciudad = modelo.Ciudad
                    });
                    _proveedorServicio.Insertar(proveedorNuevo);
                    return RedirectToAction("Index");
                }
                else
                {

                    var proveedorModificar = new ProveedorDto
                    {
                        Id = modelo.Id,
                        NombreCompania = modelo.NombreCompania,
                        Ciudad = modelo.Ciudad
                    };
                    _proveedorServicio.Modificar(proveedorModificar);
                    return RedirectToAction("Index");
                }

            }
            return View("InsertarModificar");
        }

        public ActionResult Eliminar(decimal id)
        {
            try
            {
                _proveedorServicio.Eliminar(id);
                return RedirectToAction("Index");
            }
            catch (DbUpdateException)
            {

                return RedirectToAction("SinPermisos", "Error");
            }

        }
    }
}