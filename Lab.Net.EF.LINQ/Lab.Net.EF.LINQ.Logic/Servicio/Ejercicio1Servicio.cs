using System;
using System.Collections.Generic;
using System.Linq;
using Lab.Net.EF.LINQ.Data;
using Lab.Net.EF.LINQ.Entities.Dto;


namespace Lab.Net.EF.LINQ.Logic.Servicio
{
    public class Ejercicio1Servicio : ILogic<Ejercicio1Dto>
    {
        public IEnumerable<Ejercicio1Dto> Obtener()
        {
            using (var context = new NorthwindContext())
            {
                return context.Customers

                    .AsNoTracking()
                    .Select(c => new Ejercicio1Dto
                    {

                        IdPersonalizdo = c.CustomerID,
                        NombreCompania = c.CompanyName

                    }).Take(1).ToList();
            }
        }
    }
}
