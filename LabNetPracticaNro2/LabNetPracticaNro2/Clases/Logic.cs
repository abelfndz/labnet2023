using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabNetPracticaNro2.Clases
{
    public class Logic : ILogic
    {
        public static void Excepcion()
        {
            try
            {
                throw new ExecutionEngineException();
            }
            catch (Exception error)
            {

                throw error;
            }

        }
        void ILogic.Excepcion()
        {
            Logic.Excepcion();
        }
        public static void ExcepcionPersonalizada()
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
        void ILogic.ExcepcionPersonalizada()
        {
            Logic.ExcepcionPersonalizada();
        }
    }
}
