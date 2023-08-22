using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPracticaNro2.Clases
{
    public class ExcepcionPerosnalizada : Exception
    {
        public ExcepcionPerosnalizada(string message) : base("Mensaje Base " + message) { }

        public override string Message => "Esta es una Excepcion Personalizada ";
    }
}
