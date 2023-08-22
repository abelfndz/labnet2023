using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPracticaNro2.Clases
{
    public class Division
    {
        public static void Dividirporcero(decimal numerador)
        {
            const int denominador = 0;

            decimal division;

            if (denominador == 0)
            {
                try
                {
                    division = numerador / denominador;
                }
                catch (Exception error)
                {

                    throw error;
                }
            }

        }

        public static decimal Dividirdosnumeros(decimal Dividendo, decimal Divisor)
        {

            return Dividendo / Divisor;

        }
    }
}
