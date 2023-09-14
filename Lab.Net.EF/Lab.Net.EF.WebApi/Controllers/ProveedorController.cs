using Lab.Net.EF.Logic.Empleado;
using Lab.Net.EF.Logic.Proveedor;
using Lab.Net.EF.MVC.Models;
using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI;

namespace Lab.Net.EF.WebApi.Controllers
{
    
    public class ProveedorController : ApiController
    {
        private ProveedorServicio _proveedorServicio = new ProveedorServicio();
        private ProveedorDto _proveedorDto = new ProveedorDto();
        private ProveedorView _proveedorView = new ProveedorView();

        public IHttpActionResult Get()
        {
            try
            {
                return Ok(_proveedorServicio.GetAll());
            }
            catch (Exception)
            {

                return BadRequest("Ocurrio un error al obtener los proveedor");
            }

        }

        public IHttpActionResult GetbyId(int id)
        {
            try
            {
                var proveedor = _proveedorServicio.ObtenerId(id);

                _proveedorDto.Id = proveedor.SupplierID;
                _proveedorDto.NombreCompania = proveedor.CompanyName;

                if (proveedor.ContactName != null)
                {
                    _proveedorDto.NombreContrato = proveedor.ContactName;
                }
                else
                {
                    _proveedorDto.NombreContrato = string.Empty;
                }

                if (proveedor.ContactTitle != null)
                {
                    _proveedorDto.TituloContrato = proveedor.ContactName;
                }
                else
                {
                    _proveedorDto.TituloContrato = string.Empty;
                }

                if(proveedor.Address != null)
                {
                    _proveedorDto.Direccion = proveedor.Address;
                }
                else
                {
                    _proveedorDto.Direccion = string.Empty;
                }

                if (proveedor.Country != null)
                {
                    _proveedorDto.Pais = proveedor.Country;
                }
                else
                {
                    _proveedorDto.Pais = string.Empty;
                }

                if (proveedor.City != null)
                {
                    _proveedorDto.Ciudad = proveedor.City;
                }
                else
                {
                    _proveedorDto.Ciudad = string.Empty;
                }

                if (proveedor.Phone != null)
                {
                    _proveedorDto.Telefono = proveedor.Phone;
                }
                else
                {
                    _proveedorDto.Telefono = string.Empty;
                }


                return Ok(_proveedorDto);
            }
            catch (Exception)
            {
                return BadRequest("No existe un proveedor con ese Id.");
            }
        }

        public IHttpActionResult Post([FromBody] ProveedorView _proveedorView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _proveedorDto.NombreCompania= _proveedorView.NombreCompania;
                    _proveedorDto.Ciudad= _proveedorView.Ciudad;
                    _proveedorServicio.Insertar(_proveedorDto);

                    return Ok("El empleado se inserto correctamente");
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception)
            {
                return BadRequest("ocurrio un error al insertar el empleado");
            }
        }

        public IHttpActionResult Put([FromBody] ProveedorView _proveedorView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var proveedorModificado = new ProveedorDto
                    {
                        Id = _proveedorView.Id,
                        NombreCompania = _proveedorView.NombreCompania,
                        NombreContrato = _proveedorView.NombreContrato,
                        TituloContrato = _proveedorView.TituloContrato,
                        Direccion = _proveedorView.Direccion,
                        Pais = _proveedorView.Pais,
                        Ciudad = _proveedorView.Ciudad,
                        Telefono = _proveedorView.Telefono

                    };
                    _proveedorServicio.Modificar(proveedorModificado);

                    return Ok("El Proveedor se modifico correctamente");
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception)
            {

                return BadRequest("ocurrio un error no existe el proveedor con ese id");
            }


        }

        public IHttpActionResult Delete(decimal Id)
        {
            try
            {

                _proveedorServicio.Eliminar(Id);
                return Ok("Proveedor eliminado");
            }
            catch (Exception)
            {

                return BadRequest("ocurrio un error al eliminar el proveedor o no existe proveedor con el id solicitado");
            }
        }
    }
}
