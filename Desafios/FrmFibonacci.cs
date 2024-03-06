using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafios
{
    public partial class FrmFibonacci : Form
    {
        public FrmFibonacci()
        {
            InitializeComponent();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numDigitado = Convert.ToInt32(txtNumero.Text);
            int numeroAnterior = 0;
            int numeroAtual = 1;
            int novoNumero;
            int fibonacci;
            txtNumero.Text = "";
            txtNumero.Focus();
            for (int i = 0; i < 100; i++)
            {

                fibonacci = numeroAnterior + numeroAtual;

                numeroAnterior = numeroAtual;
                numeroAtual = fibonacci;

                if (numDigitado == 0 || numDigitado == 1 || numDigitado == fibonacci)
                {
                    lblResultado.Text = "O numero pertence a sequencia Fibonacci";
                    return;
                }
                if (numDigitado < fibonacci)
                {
                    lblResultado.Text = "O numero não pertence a sequencia Fibonacci";
                    return;
                }
            }
            
            lblResultado.Text = "O numero não pertence a sequencia Fibonacci";
        }
        private void verificaNumero (int numDigitado, int fibonacci)
        {
           
        }
    }
}
