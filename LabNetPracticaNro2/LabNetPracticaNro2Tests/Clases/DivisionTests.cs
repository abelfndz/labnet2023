using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabNetPracticaNro2.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPracticaNro2.Clases.Tests
{
    [TestClass()]
    public class DivisionTests
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DividirPorCero()
        {
            decimal dividendo = 100;

            Division.DividirPorCero(dividendo);

        }
        [TestMethod]
        public void DividirDosNumeros()
        {
            decimal dividendo = 12;
            decimal divisor = 3;
            decimal resultadoEsperado = 4;

            decimal resultado = Division.DividirDosNumeros(dividendo, divisor);

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}