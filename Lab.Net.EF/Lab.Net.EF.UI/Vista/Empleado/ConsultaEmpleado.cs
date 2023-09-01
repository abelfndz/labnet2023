using Lab.Net.EF.Logic.Empleado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var fNuevoEmpleado = new NuevoEmpleado();
            fNuevoEmpleado.ShowDialog();
            ActualizarDatos(txtFiltrar.Text);
            dgvConsultaEmpleado.CurrentCell = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (EntidadId == 0)
            {
                MessageBox.Show("Debe Seleccionar un registro para borrar.");
                return;
            }
            try
            {
                DialogResult result = MessageBox.Show($"Se ELIMINARA a {EntidadNombre}" +
                    " de Forma Permanente. ¿Desea ELIMINARLO?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _empleadoServicio.Eliminar(EntidadId);
                    ActualizarDatos(txtFiltrar.Text);
                    EntidadId = 0;
                    dgvConsultaEmpleado.CurrentCell = null;
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("No tienes permiso de ADMINISTRADOR para ELIMINAR registros");
            }
            catch (Exception)
            {

                MessageBox.Show("Este registro ya fue eliminado, por favor seleccione otro");
            }
        }

        public void ActualizarDatos(string cadenaBuscar)
        {
            dgvConsultaEmpleado.DataSource = _empleadoServicio.GetAll(cadenaBuscar);
        }

        private void ConsultaEmpleado_Shown(object sender, EventArgs e)
        {
            dgvConsultaEmpleado.CurrentCell = null;
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            ActualizarDatos(txtFiltrar.Text);
        }

        private void dgvConsultaEmpleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var idSeleccionado = int.Parse(dgvConsultaEmpleado.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            var nombreSeleccionado = dgvConsultaEmpleado.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            var apellidoSeleccionado = dgvConsultaEmpleado.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
            var fModificarEmpleado = new ModificarEmpleado(idSeleccionado, nombreSeleccionado, apellidoSeleccionado);

            fModificarEmpleado.ShowDialog();
            ActualizarDatos(txtFiltrar.Text);
            dgvConsultaEmpleado.CurrentCell = null;
            EntidadId = 0;
        }

        private void dgvConsultaEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idSeleccionado = Convert.ToInt32(dgvConsultaEmpleado.Rows[e.RowIndex].Cells["ID"].Value);
                var nombreSeleccionado = dgvConsultaEmpleado.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

                this.EntidadId = idSeleccionado;
                this.EntidadNombre = nombreSeleccionado;

            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione una celda que contenga un registro");
                dgvConsultaEmpleado.CurrentCell = null;
            }

        }
    }
}
