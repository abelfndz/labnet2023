using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Net.EF.Logic.Proveedor
{
    public class ProveedorDto
    {
        public int Id { get; set; } 
        public string NombreCompania { get; set; }
        public string NombreContrato { get; set; }
        public string TituloContrato { get; set; }
        public string Direccion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public string Telefono { get; set; }
    }
}
