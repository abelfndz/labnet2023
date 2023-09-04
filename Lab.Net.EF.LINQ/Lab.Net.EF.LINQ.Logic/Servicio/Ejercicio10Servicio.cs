using Lab.Net.EF.LINQ.Data;
using Lab.Net.EF.LINQ.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Net.EF.LINQ.Logic.Servicio
{
    public class Ejercicio10Servicio : ILogic<Ejercicio10Dto>
    {
        public IEnumerable<Ejercicio10Dto> Obtener()
        {
            using (var context = new NorthwindContext())
            {
                return context.Products
                       .OrderByDescending(p => p.UnitsInStock)
                       .Select(p => new Ejercicio10Dto
                       {
                           Nombre = p.ProductName,
                           StockDeUnidades = (int)p.UnitsInStock
                       }).ToList();
            }
        }
    }
}
