﻿using Lab.Net.EF.LINQ.Logic.Servicio;
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
    public partial class Consulta6 : Form
    {
        private Ejercicio6Servicio _ejercicio6Servicio = new Ejercicio6Servicio();
        public Consulta6()
        {
            InitializeComponent();
        }

        private void Consulta6_Load(object sender, EventArgs e)
        {
            dgvMayusculaYMinuscula.DataSource = _ejercicio6Servicio.Obtener();
        }
    }
}
