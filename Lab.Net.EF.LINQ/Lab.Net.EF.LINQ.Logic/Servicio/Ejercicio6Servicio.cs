using Lab.Net.EF.LINQ.Data;
using Lab.Net.EF.LINQ.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Net.EF.LINQ.Logic.Servicio
{
    public class Ejercicio6Servicio : ILogic<Ejercicio6Dto>
    {
        public IEnumerable<Ejercicio6Dto> Obtener()
        {
            using (var context = new NorthwindContext())
            {
                return context.Customers
                       .Select(c => new Ejercicio6Dto
                       {
                           NombreMayuscula = c.CompanyName.ToUpper(),
                           NombreMinuscula = c.CompanyName.ToLower()

                       }).ToList();
            }
        }
    }
}
