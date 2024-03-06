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
    public partial class FrmLacoRepeticao : Form
    {
        public FrmLacoRepeticao()
        {
            InitializeComponent();
        }

        private void FrmLacoRepeticao_Load(object sender, EventArgs e)
        {
            int INDICE = 13, SOMA = 0, K = 0;
            while (K < INDICE ) 
            {
                K = K + 1;
                SOMA = SOMA + K;
            }
            lblValor.Text = "O valor de SOMA é : " + SOMA;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
