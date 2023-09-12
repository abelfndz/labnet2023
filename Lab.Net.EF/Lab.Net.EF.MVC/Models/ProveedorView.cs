using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.Net.EF.MVC.Models
{
    public class ProveedorView
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string NombreCompania { get; set; }
        [Required]
        [StringLength(20)]
        [RegularExpression("^[a-zA-Z\\s]+$", ErrorMessage = "Este campo no acepta valores numericos ni simbolos")]
        public string Ciudad { get; set; }
    }
}