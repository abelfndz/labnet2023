using Lab.Net.EF.LINQ.Logic.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab.Net.EF.LINQ.UI.Presentacion
{
    public partial class Consulta13 : Form
    {
        private Ejercicio13Servicio _ejercicio13Servicio = new Ejercicio13Servicio();
        public Consulta13()
        {
            InitializeComponent();
        }

        private void Consulta13_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = _ejercicio13Servicio.Obtener();
        }
    }
}
