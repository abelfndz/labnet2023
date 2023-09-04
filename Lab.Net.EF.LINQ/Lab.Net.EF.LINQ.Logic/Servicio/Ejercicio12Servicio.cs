using Lab.Net.EF.LINQ.Data;
using Lab.Net.EF.LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Net.EF.LINQ.Logic.Servicio
{
    public class Ejercicio12Servicio
    {
        public Products Obtener()
        {
            using (var context = new NorthwindContext())
            {
                var query = context.Products.First();

                return query;
            }
        }
    }
}
