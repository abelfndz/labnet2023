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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var caso1 = new Caso1();
            caso1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var caso2 = new Caso2();
            caso2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Logic.Excepcion();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Se generó una excepción de tipo " + ex.GetType().ToString() + " " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Logic.Excepcionpersonalizada();

            }
            catch (ExcepcionPerosnalizada error)
            {

                MessageBox.Show(error.Message + "\nExcepcion de Tipo: " + error.GetType().ToString());
            }
        }
    }
}
