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
    public partial class FrmInverteString : Form
    {
        public FrmInverteString()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            string palavra = txtPalavra.Text;
            StringBuilder invertida = new StringBuilder();           //Instancia um objeto da classe StringBuilder.
                                                              //Itere último ao primeiro índice da string s em i... 
            for (var i = palavra.Length - 1; i >= 0; i--)
            {
                invertida.Append(palavra[i]);                              //...acrescente o caractere s[i] ao final do objeto StringBuilder.
            }
            lblTextoInverso.Text = invertida.ToString();
            txtPalavra.Focus();
            txtPalavra.Text = "";
        }
    }
}
