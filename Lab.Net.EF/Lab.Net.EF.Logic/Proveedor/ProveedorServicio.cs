using Lab.Net.EF.Data;
using Lab.Net.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab.Net.EF.Logic.Proveedor
{
    public class ProveedorServicio : IlogicABM<ProveedorDto>
    {

        public IEnumerable<ProveedorDto> GetAll(string cadenaBuscar = "")
        {
            using (var context = new NorthwindContext())
            {
                return context.Suppliers

                     .Where(x => x.CompanyName.Contains(cadenaBuscar))

                     .Select(x => new ProveedorDto
                     {
                         Id = x.SupplierID,
                         NombreCompania = x.CompanyName,
                         Ciudad = x.City

                     }).ToList();
            }
        }
        public long Insertar(ProveedorDto dto)
        {
            using (var context = new NorthwindContext())
            {
                var nuevoProveedor = new Suppliers()
                {
                    CompanyName = dto.NombreCompania,
                    City = dto.Ciudad


                };

                context.Suppliers.Add(nuevoProveedor);

                context.SaveChanges();
                return nuevoProveedor.SupplierID;
            }
        }

        public void Modificar(ProveedorDto dto)
        {
            using (var context = new NorthwindContext())
            {
                var proveedorModificar = context.Suppliers
                    .FirstOrDefault(x => x.SupplierID == dto.Id);

                if (proveedorModificar == null)
                    throw new Exception("El Proveedor no existe");


                proveedorModificar.CompanyName = dto.NombreCompania;
                proveedorModificar.City = dto.Ciudad;
                
                context.SaveChanges();
            }

        }

        public void Eliminar(decimal Id)
        {
            using (var context = new NorthwindContext())
            {
                var proveedorEliminar = context.Suppliers
                    .FirstOrDefault(x => x.SupplierID == Id);
                context.Suppliers.Remove(proveedorEliminar);

                context.SaveChanges();
            }    
        }
     
    }
}
