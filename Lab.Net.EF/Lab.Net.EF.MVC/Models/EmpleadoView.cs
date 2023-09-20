using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.Net.EF.MVC.Models
{
    public class EmpleadoView
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        [RegularExpression("^[a-zA-Z\\s]+$", ErrorMessage = "Este campo no acepta valores numericos ni simbolos")]
        public string Nombre { get; set; }


        [Required]
        [StringLength(20)]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Este campo no acepta valores numericos ni simbolos")]
        public string Apellido { get; set; }

        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public DateTime? FechaContratacion { get; set; }
        public string Pais { get; set; }
    }
}