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
    public partial class Consulta9 : Form
    {
        private Ejercicio9Servicio _ejercicio9Servicio = new Ejercicio9Servicio();
        public Consulta9()
        {
            InitializeComponent();
        }

        private void Consulta9_Load(object sender, EventArgs e)
        {
            dgvProducto.DataSource = _ejercicio9Servicio.Obtener();
        }
    }
}
