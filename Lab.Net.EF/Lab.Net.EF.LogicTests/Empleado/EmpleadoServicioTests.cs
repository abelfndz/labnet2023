using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab.Net.EF.Logic.Empleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Lab.Net.EF.Logic.Proveedor;
using System.Reflection;

namespace Lab.Net.EF.Logic.Empleado.Tests
{
    [TestClass()]
    public class EmpleadoServicioTests
    {
        [TestMethod()]
        public void ModificarTest()
        {
            var empleadoModificar = new EmpleadoDto()
            {
                Id = 1,
                Nombre = "Abel",
                Apellido = "Fernandez"
            };

            var mock = new Mock<IlogicABM<EmpleadoDto>>();

            mock.Setup(m => m.Modificar(It.IsAny<EmpleadoDto>()))
                .Callback((EmpleadoDto empleado) =>
                empleado.Nombre = "Abel");

            mock.Object.Modificar(empleadoModificar);

            Assert.AreEqual("Abel", empleadoModificar.Nombre);
        }

        [TestMethod()]
        public void InsertarTest()
        {
            var nuevoEmpleado = new EmpleadoDto()
            {
                Id = 2,
                Nombre = "Maximiliano",
                Apellido = "Fernan"

            };

            var mock = new Mock<IlogicABM<EmpleadoDto>>();

            mock.Setup(m => m.Insertar(It.IsAny<EmpleadoDto>()))
                .Callback((EmpleadoDto empleado) =>
                empleado.Nombre = "Maximiliano");

            mock.Object.Insertar(nuevoEmpleado);

            Assert.AreEqual("Maximiliano", nuevoEmpleado.Nombre);
        }
    }
}