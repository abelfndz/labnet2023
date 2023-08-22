using LabNetPracticaNro2.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabNetPracticaNro2
{
    public partial class Caso2 : Form
    {
        public Caso2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                decimal Dividendo = decimal.Parse(txtDividendo.Text);
                decimal Divisor = decimal.Parse(txtDivisor.Text);
                decimal resultado;
                resultado = Division.Dividirdosnumeros(Dividendo, Divisor);
                lblResultado.Visible = true;
                lblResultado.BackColor = Color.White;
                lblResultado.Text = resultado.ToString();

            }
            catch (DivideByZeroException error)
            {                
                lblResultado.BackColor = Color.Red;
                lblResultado.Text = "¡Solo Chuck Norris divide\n por cero!\n y tu no eres Chuck Norris\n " + error.Message;
                lblResultado.Visible = true;
            }
            catch (Exception error)
            {
                lblResultado.BackColor = Color.Red;
                lblResultado.Text = "¡Seguro Ingreso una letra o \n no ingreso nada! \n andá pa allá bobo. \n" + error.Message;
                lblResultado.Visible = true;
            }
        }
    }
}
