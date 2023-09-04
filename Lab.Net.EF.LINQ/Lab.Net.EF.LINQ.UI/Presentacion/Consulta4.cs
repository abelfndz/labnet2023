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
    public partial class Consulta4 : Form
    {
        private Ejercicio4Servicio _ejercicio4Servicio = new Ejercicio4Servicio();
        public Consulta4()
        {
            InitializeComponent();
        }

        private void Consulta4_Load(object sender, EventArgs e)
        {
            dgvCliente.DataSource = _ejercicio4Servicio.Obtener();
        }
    }
}
