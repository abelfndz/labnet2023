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
    public partial class Consulta7 : Form
    { 
        private Ejercicio7Servicio _ejercicio7Servicio = new Ejercicio7Servicio();
        public Consulta7()
        {
            InitializeComponent();
        }

        private void Consulta7_Load(object sender, EventArgs e)
        {
            dgvPedidoDeCliente.DataSource = _ejercicio7Servicio.Obtener();
        }
    }
}
