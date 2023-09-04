using Lab.Net.EF.LINQ.Data;
using System.Linq;

namespace Lab.Net.EF.LINQ.Logic.Servicio
{
    public class Ejercicio5Servicio
    {
        public string Obtener()
        {
            using (var context = new NorthwindContext())
            {
                var query = context.Products.FirstOrDefault(p => p.ProductID == 789);

                if (query != null)
                {
                    return query.ProductName.ToString();
                }
                else
                {
                    return "Producto no encontrado";
                }


            }
        }
    }
}
