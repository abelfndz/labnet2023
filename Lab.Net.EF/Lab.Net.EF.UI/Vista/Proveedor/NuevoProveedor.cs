using Lab.Net.EF.Logic.Empleado;
using Lab.Net.EF.Logic.Proveedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab.Net.EF.UI.Vista.Proveedor
{
    public partial class NuevoProveedor : Form
    {
        private ProveedorServicio _proveedorServicio = new ProveedorServicio();
        public NuevoProveedor()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevoProveedor = new ProveedorDto
                {
                    NombreCompania = txtNombreCompania.Text,
                    Ciudad = txtCiudad.Text,
                };

                _proveedorServicio.Insertar(nuevoProveedor);

                MessageBox.Show("Nuevo Proveedor guardado con exito!");
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("NO se pertinen campos vacios!!");

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
