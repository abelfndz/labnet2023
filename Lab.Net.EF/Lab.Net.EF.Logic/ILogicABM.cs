using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Net.EF.Logic
{
    public interface IlogicABM<T>
    {
        IEnumerable<T> GetAll(string cadenaBuscar);
        long Insertar(T dto);
        void Modificar(T dto);
        void Eliminar(decimal Id);
    }
}
