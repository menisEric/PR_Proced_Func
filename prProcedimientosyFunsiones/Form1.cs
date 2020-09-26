using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prProcedimientosyFunsiones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int _numero1;
        private int _numero2;

        public int Numero1 { get => _numero1; set => _numero1 = value; }
        public int Numero2 { get => _numero2; set => _numero2 = value; }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;

            numero1 = Convert.ToInt32(txtNumero1.Text);
            numero2 = Convert.ToInt32(txtNumero2.Text);

            int suma;

            suma = sumar(numero1, numero2);
            txtResultado.Text = Convert.ToString(suma);

        }
        private int sumar(int num1, int num2)
        {
            int resultado;
            resultado = num1 + num2;
            return resultado;
        }
        private Double operaciones(int num1, int num2, string op)
        {
            Double resultado;
            if (op == "s")
            {
                resultado = num1 + num2;
            }
            else if (op=="r")
            {
                resultado = num1 - num2;
            }
            else if (op=="m")
            {
                resultado = num1 * num2;
            }
            else
            {
                resultado = num1 / num2;
            }
            return resultado;
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;
            Double resultado;

            numero1 = Convert.ToInt32(txtNumero1.Text);
            numero2 = Convert.ToInt32(txtNumero2.Text);

            resultado = operaciones(numero1, numero2, "r");

            txtResultado.Text = Convert.ToString(resultado);
            
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;
            Double resultado;

            numero1 = Convert.ToInt32(txtNumero1.Text);
            numero2 = Convert.ToInt32(txtNumero2.Text);

            resultado = operaciones(numero1, numero2, "m");

            txtResultado.Text = Convert.ToString(resultado);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;
            Double resultado;

            numero1 = Convert.ToInt32(txtNumero1.Text);
            numero2 = Convert.ToInt32(txtNumero2.Text);

            resultado = operaciones(numero1, numero2, "d");

            txtResultado.Text = Convert.ToString(resultado);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Numero1 = 10;
            Numero2 = 30;
            int suma;
            suma = Numero1 + Numero2;
            txtResultado.Text = Convert.ToString(suma);

        }
        struct cliente
        {
            public string nombre;
            public string apellido;
            public string telefono;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cliente cliente1;
            cliente1.nombre = "Eric Leonel";
            cliente1.apellido = "Menis";
            cliente1.telefono = "1150050241";
        }
    }
}
