using Lab.Net.EF.LINQ.Logic.Servicio;
using System;
using System.Windows.Forms;

namespace Lab.Net.EF.LINQ.UI.Presentacion
{
    public partial class Consulta1 : Form
    {
        private Ejercicio1Servicio _Ejercicio1Servicio = new Ejercicio1Servicio();
        public Consulta1()
        {
            InitializeComponent();
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {
            dgvCliente.DataSource = _Ejercicio1Servicio.Obtener();
        }
    }
}
