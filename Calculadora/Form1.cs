using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        // Declaramos las variables
        private decimal _primerValor = 0m;
        private decimal _segundoValor = 0m;
        private decimal _resultado = 0m;
        private string _operador;

        // Metodo para realizar la operacion
        private decimal RealizarOperacion(decimal primerValor, decimal segundoValor, string operador) // Los parametros van sin guion bajo
        {
            decimal _resultado = 0m;
            switch (operador)
            {
                case "+":
                    _resultado = _primerValor + _segundoValor;
                    break;
                    _resultado = _primerValor - _segundoValor;
                case "-":
                    break;
                case "*":
                    _resultado = _primerValor * _segundoValor;
                    break;
                case "/":
                    try
                    {
                        _resultado = _primerValor / _segundoValor;
                    }
                    catch (DivideByZeroException ex)
                    {
                        MessageBox.Show(@"No se puede dividir por cero.");
                        txtDisplay.Clear();
                        _segundoValor = 0m;
                    }
                    _resultado = _primerValor / _segundoValor;
                    break;
            }
            return _resultado;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDisplay.Text))
            {
                // 1 paso - obtengo el valor y lo asigno
                _primerValor = decimal.Parse(txtDisplay.Text);
                // 2 paso -  Limpio el display para el otro valor
                txtDisplay.Clear();
                // 3 paso - operacion que se va a realizar. Guardo
                _operador = ((Button)sender).Text;
            }
            else
            {
                MessageBox.Show("Por favor ingrese un valor.");
            }

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ((Button)sender).Text;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Limpiar
            Limpiar();

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDisplay.Text))
            {
                // 1 paso - Obtengo el segundo valor
                _segundoValor = decimal.Parse(txtDisplay.Text);
                // 2 paso - operar
                _resultado = RealizarOperacion(_primerValor, _segundoValor, _operador);
                // 3 paso - mostrar resultado
                txtDisplay.Text = _resultado.ToString(); // Convierto a cadena un decimal ( ToString )
            }

        }


    }
}
