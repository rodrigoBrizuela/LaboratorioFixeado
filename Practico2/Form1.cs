using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico2
{
    public partial class Calculadora : Form
    {
        // Declarar
        int _a;

        // Constructor 
  
        public Calculadora()
        {
            InitializeComponent(); // Inicializa el programa. ¡¡IMPORTANTE!!

            // Inicializar
            int _a = 0;
        }

        private void btnMensaje_Click(object sender, EventArgs e)
        { 
            string _mensaje = txtDisplay.Text; // Declaro la variable mensaje asignada al txtDisplay / Aca obtengo lo que vamos a escribir

            MessageBox.Show(_mensaje); // Muestro un mensaje segun lo que escribo en el string _mensaje
        }

        private void btnAsignarDatos_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0"; // Aca le asigno la palabra Hola

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear(); // Limpiar calculadora
            txtDisplay.Focus(); // Posiciona el foco en el control

        }
    }
}
