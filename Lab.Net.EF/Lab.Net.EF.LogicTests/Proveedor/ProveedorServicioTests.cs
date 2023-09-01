using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab.Net.EF.Logic.Proveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace Lab.Net.EF.Logic.Proveedor.Tests
{
    [TestClass()]
    public class ProveedorServicioTests
    {
        [TestMethod()]
        public void ModificarTest()
        {
            var proveedorModificar = new ProveedorDto()
            {
                Id = 1,
                NombreCompania = "Company S.A",
                Ciudad = "Tucumán"
            };

            var mock = new Mock<IlogicABM<ProveedorDto>>();

            mock.Setup(m => m.Modificar(It.IsAny<ProveedorDto>()))
                .Callback((ProveedorDto proveedor) =>
                proveedor.NombreCompania = "Company S.A");

            mock.Object.Modificar(proveedorModificar);

            Assert.AreEqual("Company S.A", proveedorModificar.NombreCompania);
        }

        [TestMethod()]
        public void InsertarTest()
        {
            var nuevoModificar = new ProveedorDto()
            {
                Id = 2,
                NombreCompania = "Enterprise S.A",
                Ciudad = "Buenos Aires"
            };

            var mock = new Mock<IlogicABM<ProveedorDto>>();

            mock.Setup(m => m.Insertar(It.IsAny<ProveedorDto>()))
                .Callback((ProveedorDto proveedor) =>
                proveedor.NombreCompania = "Enterprise S.A");

            mock.Object.Insertar(nuevoModificar);

            Assert.AreEqual("Enterprise S.A", nuevoModificar.NombreCompania);
        }
    }
}