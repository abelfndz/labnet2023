using Lab.Net.EF.LINQ.Entities;
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
    public partial class Consulta12 : Form
    {
        private Ejercicio12Servicio _ejercicio12Servicio = new Ejercicio12Servicio();

        public Consulta12()
        {
            InitializeComponent();
        }

        private void Consulta12_Load(object sender, EventArgs e)
        {
            Products p = _ejercicio12Servicio.Obtener();
            lblProcucto.Text = p.ProductName + " " + p.UnitPrice;
            lblProcucto.Visible = true;
        }
    }
}
