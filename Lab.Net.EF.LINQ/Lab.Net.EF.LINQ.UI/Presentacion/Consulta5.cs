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
    public partial class Consulta5 : Form
    {
        private Ejercicio5Servicio _ejercicio5Servicio = new Ejercicio5Servicio();
        public Consulta5()
        {
            InitializeComponent();
        }

        private void Consulta5_Load(object sender, EventArgs e)
        {
            lblIdProcucto.Text = _ejercicio5Servicio.Obtener();
            lblIdProcucto.Visible = true;
        }
    }
}
