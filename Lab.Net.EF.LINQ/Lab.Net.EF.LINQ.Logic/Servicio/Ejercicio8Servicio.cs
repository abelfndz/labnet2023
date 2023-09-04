using Lab.Net.EF.LINQ.Data;
using Lab.Net.EF.LINQ.Entities.Dto;
using System.Collections.Generic;
using System.Linq;

namespace Lab.Net.EF.LINQ.Logic.Servicio
{
    public class Ejercicio8Servicio : ILogic<Ejercicio8Dto>
    {
        public IEnumerable<Ejercicio8Dto> Obtener()
        {
            using (var context = new NorthwindContext())
            {
                var query = (from c in context.Customers
                             where c.Region == "WA"
                             select new Ejercicio8Dto
                             {
                                 Nombre = c.CompanyName,
                                 Region = c.Region
                             }).Take(3).ToList();

                return query;

            }
        }
    }
}
