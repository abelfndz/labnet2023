using Lab.Net.EF.LINQ.Data;
using Lab.Net.EF.LINQ.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Net.EF.LINQ.Logic.Servicio
{
    public class Ejercicio9Servicio: ILogic<Ejercicio9Dto>
    {
        public IEnumerable<Ejercicio9Dto> Obtener()
        {
            using (var context = new NorthwindContext())
            {
                var query = (from p in context.Products
                             orderby p.ProductName
                             select new Ejercicio9Dto
                             {
                                 IdProducto = p.ProductID,
                                 Nombre = p.ProductName,
                             }).ToList();

                return query;
            }
        }
    }
}
