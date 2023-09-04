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
    public partial class Consulta11 : Form
    {
        private Ejercicio11Servicio _ejercicio11Servicio = new Ejercicio11Servicio();
        public Consulta11()
        {
            InitializeComponent();
        }

        private void Consulta11_Load(object sender, EventArgs e)
        {
            dgvCategorias.DataSource = _ejercicio11Servicio.Obtener();
        }
    }
}
