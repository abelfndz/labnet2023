using Lab.Net.EF.LINQ.Data;
using Lab.Net.EF.LINQ.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Net.EF.LINQ.Logic.Servicio
{
    public class Ejercicio4Servicio : ILogic<Ejercicio4Dto>
    {
        public IEnumerable<Ejercicio4Dto> Obtener()
        {
            using (var context = new NorthwindContext())
            {
                var query = from c in context.Customers
                            where c.Region == "WA"
                            select new Ejercicio4Dto()
                            {
                                Cliente = c.CompanyName,
                                Region = c.Region
                            };
                return query.ToList();
            }
        }
    }
}
