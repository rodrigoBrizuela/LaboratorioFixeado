using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ((Button)sender).Text; ; // Ingresa el valor 0. el += para que se concadenen. Se le asigna el contenido del boton btn0.Text a display.Text
        }

    }
}
