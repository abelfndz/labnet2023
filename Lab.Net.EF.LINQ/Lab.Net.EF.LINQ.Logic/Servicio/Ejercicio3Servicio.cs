using Lab.Net.EF.LINQ.Data;
using Lab.Net.EF.LINQ.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Net.EF.LINQ.Logic.Servicio
{
    public class Ejercicio3Servicio : ILogic<Ejercicio3Dto>
    {
        public IEnumerable<Ejercicio3Dto> Obtener()
        {
            using (var context = new NorthwindContext())
            {
                var query = from p in context.Products
                            where p.UnitsInStock > 0 && p.UnitPrice > 3

                            select new Ejercicio3Dto
                            {

                                Nombre = p.ProductName,
                                Precio = (decimal)p.UnitPrice,
                                Stock = (int)p.UnitsInStock
                            };

                return query.ToList();
            }

        }
    }
}
