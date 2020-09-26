using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prGestionAhorros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            desactivarControles();
        }

        private Double monto;

        private void activarControles()
        {
            txtCliente.Enabled = false;
            txtMonto.Enabled = false;
            btnAbrirCuenta.Enabled = false;

            btnDeposito.Enabled = false;
            btnRegistro.Enabled = false;

        }

        private void desactivarControles()
        {
            txtCliente.Enabled = true;
            txtMonto.Enabled = true;
            btnAbrirCuenta.Enabled = true;

            btnDeposito.Enabled = true;
            btnRegistro.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cliente;

            cliente = txtCliente.Text;
            monto = Convert.ToDouble(txtMonto.Text);

            if (monto > 0)
            {
                activarControles();
            }
            else
            {
                MessageBox.Show("El monto debe ser mayor o igual a cero", "Gestion de Ahorros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Double leer(string mensaje)
        {
            Double cantidad;
            cantidad = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese monto a " + mensaje, "Gestion de ahorros", "", 100, 0));
            return cantidad;
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            Double deposito;
            deposito = leer("Depositar");
            monto = monto + deposito;
            lstDeposito.Items.Add(deposito);
            mostrar();
        }

        private void mostrar()
        {
            txtSaldo.Text = Convert.ToString(monto);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Double retiro;
            retiro = leer("Retirar");

            if (retiro<=monto)
            {
                monto = monto - retiro;
                lstRetiro.Items.Add(retiro);
            }
            else
            {
                MessageBox.Show("Ls csntidad de retiro es mayor al monto disponible", "Gestion de ahorros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtMonto.Clear();
            txtSaldo.Clear();
            lstDeposito.Items.Clear();
            lstRetiro.Items.Clear();
            desactivarControles();
        }
    }
}
