using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPracticaNro2.Clases
{
    public interface IDivision
    {
        void DividirPorCero(decimal numerador);
        void DividirDosNumeros(decimal Dividendo, decimal Divisor);
    }
}
