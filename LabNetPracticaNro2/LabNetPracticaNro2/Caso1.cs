using LabNetPracticaNro2.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabNetPracticaNro2
{
    public partial class Caso1 : Form
    {
        public Caso1()
        {
            InitializeComponent();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                Division.Dividirporcero(numNumerador.Value);
            }
            catch (Exception error)
            {
                lblError.Text = error.Message + "\nNo se puede divir por cero (0)";
                lblError.Visible = true;

            }
            finally
            {
                MessageBox.Show("Operacion realizada con exito");
            }
        }
    }
}
