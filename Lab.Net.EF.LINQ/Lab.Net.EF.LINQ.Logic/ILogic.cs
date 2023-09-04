using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Net.EF.LINQ.Logic
{
    internal interface ILogic<T>
    {
        IEnumerable<T> Obtener();
    }
}
