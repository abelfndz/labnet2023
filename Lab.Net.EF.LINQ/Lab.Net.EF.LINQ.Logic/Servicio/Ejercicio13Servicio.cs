using Lab.Net.EF.LINQ.Data;
using Lab.Net.EF.LINQ.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Net.EF.LINQ.Logic.Servicio
{
    public class Ejercicio13Servicio : ILogic<Ejercicio13Dto>
    {
        public IEnumerable<Ejercicio13Dto> Obtener()
        {

            using (var context = new NorthwindContext())
            {
                var customerOrderCounts = context.Customers
                   .Join(context.Orders, c => c.CustomerID, o => o.CustomerID, (c, o)
                    => new { Customer = c, Order = o })
                   .GroupBy(co => co.Customer.CompanyName)
                   .Select(g => new Ejercicio13Dto
                   {
                       Cliente = g.Key,
                       Pedidos = g.Count()
                   }).ToList();

                return customerOrderCounts;

            }
        }
    }
}
