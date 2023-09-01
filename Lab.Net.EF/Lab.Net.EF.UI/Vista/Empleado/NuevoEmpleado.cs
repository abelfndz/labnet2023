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
    public partial class NuevoEmpleado : Form
    {
        private EmpleadoServicio _empleadoServicio = new EmpleadoServicio();
        public NuevoEmpleado()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevoEmpleado = new EmpleadoDto
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                };

                _empleadoServicio.Insertar(nuevoEmpleado);

                MessageBox.Show("Nuevo Empleado guardado con exito!");
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
    }
}
