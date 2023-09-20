using Lab.Net.EF.Logic.Empleado;
using Lab.Net.EF.MVC.Models;
using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Results;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace Lab.Net.EF.WebApi.Controllers
{
    [System.Web.Http.Cors.EnableCors("*", "*", "*")]
    public class EmpleadosController : ApiController
    {
        private EmpleadoServicio _empleadoServicio = new EmpleadoServicio();
        private EmpleadoDto _empleadoDto = new EmpleadoDto();
        private EmpleadoView _empleadoView = new EmpleadoView();
       
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(_empleadoServicio.GetAll());
            }
            catch (Exception)
            {

                return BadRequest("Ocurrio un error al obtener los empleados");
            }

        }

        public IHttpActionResult GetbyId(int id)
        {
            try
            {
                var empleado = _empleadoServicio.ObtenerId(id);

                _empleadoDto.Id = empleado.EmployeeID;
                _empleadoDto.Nombre = empleado.FirstName;
                _empleadoDto.Apellido = empleado.LastName;

                if (empleado.Address != null)
                {
                    _empleadoDto.Direccion = empleado.Address;
                }
                else
                {
                    _empleadoDto.Direccion = string.Empty;
                }

                if (empleado.Country != null)
                {
                    _empleadoDto.Pais = empleado.Country;
                }
                else
                {
                    _empleadoDto.Pais = string.Empty;
                }

                if (empleado.HireDate != null)
                {
                    _empleadoDto.FechaContratacion = (DateTime)empleado.HireDate;
                }
                else
                {
                    _empleadoDto.FechaContratacion = new DateTime();
                }

                if (empleado.City != null)
                {
                    _empleadoDto.Ciudad = empleado.City;
                }
                else
                {
                    _empleadoDto.Ciudad = string.Empty;
                }


                return Ok(_empleadoDto);
            }
            catch (Exception)
            {
                return BadRequest("No existe un empleado con ese Id.");
            }
        }

        public IHttpActionResult Post([FromBody] EmpleadoView _empleadoView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _empleadoDto.Nombre = _empleadoView.Nombre;
                    _empleadoDto.Apellido = _empleadoView.Apellido;
                    _empleadoDto.Pais = _empleadoView.Pais;
                    _empleadoDto.Ciudad = _empleadoView.Ciudad;
                    _empleadoDto.Direccion = _empleadoView.Direccion;

                    _empleadoServicio.Insertar(_empleadoDto);

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

        public IHttpActionResult Put([FromBody] EmpleadoView _empleadoView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var empleadoModificado = new EmpleadoDto
                    {
                        Id = _empleadoView.Id,
                        Nombre = _empleadoView.Nombre,
                        Apellido = _empleadoView.Apellido,
                        Pais = _empleadoView.Pais,
                        Ciudad = _empleadoView.Ciudad,
                        Direccion = _empleadoView.Direccion

                    };
                    _empleadoServicio.Modificar(empleadoModificado);

                    return Ok("El empleado se modifico correctamente");
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception)
            {

                return BadRequest("ocurrio un error no existe empleado con ese id");
            }


        }

        public IHttpActionResult Delete(int Id)
        {
            try
            {

                _empleadoServicio.Eliminar(Id);
                return Ok("Empleado eliminado");
            }
            catch (Exception)
            {

                return BadRequest("ocurrio un error al eliminar el empleado o no existe empleado con el id solicitado");
            }
        }

    }
}