using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPracticaNro2.Clases
{
    public class Division :IDivision
    {

        public static void DividirPorCero(decimal numerador)
        {
            const int denominador = 0;

            decimal division;

                try
                {
                    division = numerador / denominador;
                }
                catch (Exception error)
                {

                    throw error;
                }

        }
        void IDivision.DividirPorCero(decimal numerador)
        {
            Division.DividirPorCero(numerador);
        }

        public static decimal DividirDosNumeros(decimal Dividendo, decimal Divisor)
        {

            return Dividendo / Divisor;

        }

        void IDivision.DividirDosNumeros(decimal Dividendo, decimal Divisor)
        {
            Division.DividirDosNumeros(Dividendo, Divisor);
        }
    }
}
