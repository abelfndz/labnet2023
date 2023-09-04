using Lab.Net.EF.LINQ.Data;
using Lab.Net.EF.LINQ.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Net.EF.LINQ.Logic.Servicio
{
    public class Ejercicio2Servicio : ILogic<Ejercicio2Dto>
    {
        public IEnumerable<Ejercicio2Dto> Obtener()
        {
            using (var context = new NorthwindContext())
            {
                return context.Products
                    .Where(p => p.UnitsInStock == 0)
                    .Select(p => new Ejercicio2Dto()
                    {

                        Nombre = p.ProductName,
                        StockDeUnidades = (int)p.UnitsInStock

                    }).ToList();
            }
        }
    }
}
