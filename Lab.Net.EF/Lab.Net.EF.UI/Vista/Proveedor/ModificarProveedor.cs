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
    public partial class ModificarProveedor : Form
    {
        private ProveedorServicio _proveedorServicio = new ProveedorServicio();
        public ModificarProveedor()
        {
            InitializeComponent();
        }

        public ModificarProveedor(int id, string nombreCompania, string ciudad)
        {

            InitializeComponent();
            nunId.Value = id;
            nunId.Enabled = false;

            txtNombreCompania.Text = nombreCompania;
            txtCiudad.Text = ciudad;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var proveedorModificar = new ProveedorDto()
                {
                    Id = (long)nunId.Value,
                    NombreCompania = txtNombreCompania.Text,
                    Ciudad = txtCiudad.Text
                };

                _proveedorServicio.Modificar(proveedorModificar);
                MessageBox.Show("Modificacion del registro correctamente!");
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
