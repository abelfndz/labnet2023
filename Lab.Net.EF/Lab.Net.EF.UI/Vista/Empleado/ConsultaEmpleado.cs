using Lab.Net.EF.Logic.Empleado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab.Net.EF.UI.Vista.Empleado
{
    public partial class ConsultaEmpleado : Form
    {
        private int EntidadId = 0;
        private string EntidadNombre;

        private EmpleadoServicio _empleadoServicio = new EmpleadoServicio();
        public ConsultaEmpleado()
        {
            InitializeComponent();
        }

        private void ConsultaEmpleado_Load(object sender, EventArgs e)
        {
            dgvConsultaEmpleado.DataSource = _empleadoServicio.GetAll();
        }

        public void ActualizarDatos(string cadenaBuscar)
        {
            dgvConsultaEmpleado.DataSource = _empleadoServicio.GetAll(cadenaBuscar);
        }

        private void ConsultaEmpleado_Shown(object sender, EventArgs e)
        {
            dgvConsultaEmpleado.CurrentCell = null;
        }
    }
}
