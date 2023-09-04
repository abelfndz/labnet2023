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
    public partial class Consulta8 : Form
    {
        private Ejercicio8Servicio _ejercicio8Servicio = new Ejercicio8Servicio();
        public Consulta8()
        {
            InitializeComponent();
        }

        private void Consulta8_Load(object sender, EventArgs e)
        {
            dgvClientesWa.DataSource = _ejercicio8Servicio.Obtener();
        }
    }
}
