using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPracticaNro2.Clases
{
    public class Logic
    {
        public static void Excepcion()
        {
            try
            {
                throw new ArgumentOutOfRangeException();
            }
            catch (Exception error)
            {

                throw error;
            }

        }
        public static void Excepcionpersonalizada()
        {
            try
            {
                throw new ExcepcionPerosnalizada(" Mensaje Sobrecargado");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
