using Lab.Net.EF.Data;
using Lab.Net.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab.Net.EF.Logic.Empleado
{
    public class EmpleadoServicio : IlogicABM<EmpleadoDto>
    {

        private NorthwindContext _northwindContext = new NorthwindContext();

        public EmpleadoServicio()
        {
            _northwindContext = new NorthwindContext();
        }

        public IEnumerable<EmpleadoDto> GetAll(string cadenaBuscar = "")
        {
            using (var context = new NorthwindContext())
            {
                return context.Employees

                     .AsNoTracking()
                     .Where(x => x.LastName.Contains(cadenaBuscar) ||

                                 x.FirstName.Contains(cadenaBuscar))

                     .Select(x => new EmpleadoDto
                     {
                         Id = x.EmployeeID,
                         Nombre = x.FirstName,
                         Apellido = x.LastName,
                         Direccion = x.Address,
                         Ciudad = x.City,
                         FechaContratacion = (DateTime?)x.HireDate ?? DateTime.MinValue,
                         Pais = x.Country

                     }).ToList();
            }
        }



        public long Insertar(EmpleadoDto dto)
        {
            using (var context = new NorthwindContext())
            {
                var nuevoEmpleado = new Employees()
                {
                    FirstName = dto.Nombre,
                    LastName = dto.Apellido,
                    Country = dto.Pais,
                    City = dto.Ciudad,
                    Address = dto.Direccion,
                };

                context.Employees.Add(nuevoEmpleado);

                context.SaveChanges();
                return nuevoEmpleado.EmployeeID;
            }
        }

        public void Modificar(EmpleadoDto dto)
        {
            using (var context = new NorthwindContext())
            {
                var empleadoModificar = context.Employees
                    .FirstOrDefault(x => x.EmployeeID == dto.Id);

                if (empleadoModificar == null)
                    throw new Exception("El Empleado no existe");

                empleadoModificar.FirstName = dto.Nombre;
                empleadoModificar.LastName = dto.Apellido;
                empleadoModificar.Country = dto.Pais;
                empleadoModificar.City = dto.Ciudad;
                empleadoModificar.Address = dto.Direccion;

                context.SaveChanges();
            }
        }

        public Employees ObtenerId(int id)
        {
            using (var context = new NorthwindContext())
            {
                return context.Employees.FirstOrDefault(e => e.EmployeeID == id);
            }
        }

        public void Eliminar(int Id)
        {
            using (var context = new NorthwindContext())
            {
                var empleadoEliminar = context.Employees
                    .FirstOrDefault(x => x.EmployeeID == Id);

                if (empleadoEliminar == null)
                    throw new Exception("El Empleado no existe");
                context.Employees.Remove(empleadoEliminar);

                context.SaveChanges();

            }
        }
    }
}
