using Lab.Net.EF.Logic.Empleado;
using Lab.Net.EF.Logic.Proveedor;
using Lab.Net.EF.UI.Vista.Empleado;
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

namespace Lab.Net.EF.UI.Vista.Proveedor
{
    public partial class ConsultaProveedor : Form
    {
        private int EntidadId = 0;
        private string EntidadNombreCompania;

        private ProveedorServicio _proveedorServicio = new ProveedorServicio();

        public ConsultaProveedor()
        {
            InitializeComponent();
        }

        private void ConsultaProveedor_Load(object sender, EventArgs e)
        {
            dgvConsultaProveedor.DataSource = _proveedorServicio.GetAll();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var fNuevoProveedor = new NuevoProveedor();
            fNuevoProveedor.ShowDialog();
            ActualizarDatos(txtFiltrar.Text);
            dgvConsultaProveedor.CurrentCell = null;
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
                DialogResult result = MessageBox.Show($"Se ELIMINARA a {EntidadNombreCompania}" +
                    " de Forma Permanente. ¿Desea ELIMINARLO?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _proveedorServicio.Eliminar(EntidadId);
                    ActualizarDatos(txtFiltrar.Text);
                    EntidadId = 0;
                    dgvConsultaProveedor.CurrentCell = null;
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
            dgvConsultaProveedor.DataSource = _proveedorServicio.GetAll(cadenaBuscar);
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            ActualizarDatos(txtFiltrar.Text);
        }

        private void ConsultaProveedor_Shown(object sender, EventArgs e)
        {
            dgvConsultaProveedor.CurrentCell = null;
        }

        private void dgvConsultaProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var idSeleccionado = int.Parse(dgvConsultaProveedor.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            var nombreCompaniaSeleccionado = dgvConsultaProveedor.Rows[e.RowIndex].Cells["NombreCompania"].Value.ToString();
            var ciudadSeleccionado = dgvConsultaProveedor.Rows[e.RowIndex].Cells["Ciudad"].Value.ToString();
            var fModificarProveedor = new ModificarProveedor(idSeleccionado, nombreCompaniaSeleccionado, ciudadSeleccionado);

            fModificarProveedor.ShowDialog();
            ActualizarDatos(txtFiltrar.Text);
            dgvConsultaProveedor.CurrentCell = null;
            EntidadId = 0;
        }

        private void dgvConsultaProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idSeleccionado = Convert.ToInt32(dgvConsultaProveedor.Rows[e.RowIndex].Cells["ID"].Value);
                var nombreCompaniaSeleccionado = dgvConsultaProveedor.Rows[e.RowIndex].Cells["NombreCompania"].Value.ToString();

                this.EntidadId = idSeleccionado;
                this.EntidadNombreCompania = nombreCompaniaSeleccionado;

            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione una celda que contenga un registro");
                dgvConsultaProveedor.CurrentCell = null;
            }
        }
    }
}
