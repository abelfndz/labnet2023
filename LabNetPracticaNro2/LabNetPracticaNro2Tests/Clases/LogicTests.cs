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
    public class LogicTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ExecutionEngineException))]
        public void ExcepcionTest()
        {
            Logic.Excepcion();
        }

        [TestMethod()]
        [ExpectedException(typeof(ExcepcionPerosnalizada))]
        public void ExcepcionPersonalizada()
        {
            Logic.ExcepcionPersonalizada();
        }
    }
}