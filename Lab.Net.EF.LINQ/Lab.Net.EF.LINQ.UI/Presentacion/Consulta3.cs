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
    public partial class Consulta3 : Form
    {
        private Ejercicio3Servicio _ejercicio3Servicio = new Ejercicio3Servicio();
        public Consulta3()
        {
            InitializeComponent();
        }

        private void Consulta3_Load(object sender, EventArgs e)
        {
            dgvProducto.DataSource = _ejercicio3Servicio.Obtener();
        }
    }
}
