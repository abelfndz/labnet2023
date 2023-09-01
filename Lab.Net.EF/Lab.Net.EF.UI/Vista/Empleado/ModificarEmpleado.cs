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
    public partial class ModificarEmpleado : Form
    {
        private EmpleadoServicio _empleadoServicio = new EmpleadoServicio();
        public ModificarEmpleado()
        {
            InitializeComponent();
        }

        public ModificarEmpleado(int id, string nombre, string apellido)
        {

            InitializeComponent();
            nunId.Value = id;
            nunId.Enabled = false;

            txtNombre.Text = nombre;
            txtApellido.Text = apellido;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var empleadoModificar = new EmpleadoDto()
                {
                    Id = (long)nunId.Value,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text
                };

                _empleadoServicio.Modificar(empleadoModificar);
                MessageBox.Show("Modificacion del registro correctamente!");
                this.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("NO se pertinen campos vacios!!");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
