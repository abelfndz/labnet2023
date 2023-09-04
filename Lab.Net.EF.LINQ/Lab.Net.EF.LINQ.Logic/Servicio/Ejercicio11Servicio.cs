using Lab.Net.EF.LINQ.Data;
using Lab.Net.EF.LINQ.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Net.EF.LINQ.Logic.Servicio
{
    public class Ejercicio11Servicio : ILogic<Ejercicio11Dto>
    {
        public IEnumerable<Ejercicio11Dto> Obtener()
        {
            using (var context = new NorthwindContext())
            {
                var query = (from c in context.Categories
                             join p in context.Products on c.CategoryID equals p.CategoryID
                             select new Ejercicio11Dto
                             {
                                 IdCategoria = c.CategoryID,
                                 Categoria = c.CategoryName
                             }).Distinct().ToList();

                return query;

            }
        }
    }
}
