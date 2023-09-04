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
    public partial class Consulta10 : Form
    {
        private Ejercicio10Servicio _ejercicio10Servicio = new Ejercicio10Servicio();
        public Consulta10()
        {
            InitializeComponent();
        }

        private void Consulta10_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = _ejercicio10Servicio.Obtener();
        }
    }
}
