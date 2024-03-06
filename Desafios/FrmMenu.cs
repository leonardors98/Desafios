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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnDesafio1_Click(object sender, EventArgs e)
        {
            FrmLacoRepeticao lacoRepeticao = new FrmLacoRepeticao();
            lacoRepeticao.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmFibonacci fibonacci = new FrmFibonacci();
            fibonacci.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmInverteString inverteString = new FrmInverteString();
            inverteString.Show();
        }
    }
}
