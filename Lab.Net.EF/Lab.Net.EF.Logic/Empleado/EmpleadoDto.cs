using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Net.EF.Logic.Empleado
{
    public class EmpleadoDto
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public DateTime FechaContratacion { get; set; }
        public string Pais { get; set; }
    }
}
