using Lab.Net.EF.UI.Vista.Empleado;
using Lab.Net.EF.UI.Vista.Proveedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab.Net.EF.UI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            var fConsultaEmpleado = new ConsultaEmpleado();

            fConsultaEmpleado.ShowDialog();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            var fConsultaProveedor = new ConsultaProveedor();

            fConsultaProveedor.ShowDialog();
        }
    }
}
