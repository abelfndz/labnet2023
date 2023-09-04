using Lab.Net.EF.LINQ.Logic.Servicio;
using System;
using System.Windows.Forms;

namespace Lab.Net.EF.LINQ.UI.Presentacion
{
    public partial class Consulta2 : Form
    {
        private Ejercicio2Servicio _ejercicio2Servicio = new Ejercicio2Servicio();
        public Consulta2()
        {
            InitializeComponent();
        }

        private void Consulta2_Load(object sender, EventArgs e)
        {
            dgvStock.DataSource = _ejercicio2Servicio.Obtener();
        }
    }
}
