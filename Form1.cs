using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula04fase2APPbanco
{
    public partial class Form1 : Form
    {
        static double somaSaldo;
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblDeposito_Click(object sender, EventArgs e)//escrita deposito titulo2
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)//boto salvar
        {
            double valor;
            valor = double.Parse(txtValor.Text);
            
            if (lblDeposito.Text == "SACAR") 
            {
                if (somaSaldo < valor)
                {
                    MessageBox.Show("Voce nao possue essa quantia na conta...");
                    return;
                }

                lblSaldoValor.Text = ("R$:" + valor);

                lblSaldoValor.Text = "R$" + (somaSaldo - valor);
                somaSaldo = somaSaldo - valor;

            }
            else
            {
                lblSaldoValor.Text = ("R$:" + valor);

                lblSaldoValor.Text = "R$" + (somaSaldo + valor);
                somaSaldo = somaSaldo + valor;
            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnDepositar_Click(object sender, EventArgs e)//botao depositar
        {
            btnDepositar.ForeColor = Color.Black;
            btnDepositar.BackColor = Color.DarkViolet;


            btnSacar.ForeColor = Color.White;
            btnSacar.BackColor = Color.Black;
            
            
            lblDeposito.Text = "DEPÓSITO";
        }

        private void btnExtrato_Click(object sender, EventArgs e)//botao extrato
        {

        }

        private void lblSaldoValor_Click(object sender, EventArgs e)
        {

        }

        private void btnSacar_Click(object sender, EventArgs e)//botao sacar
        {
            btnSacar.ForeColor = Color.Black;
            btnSacar.BackColor = Color.DarkViolet;


            btnDepositar.ForeColor = Color.White;
            btnDepositar.BackColor = Color.Black;

            lblDeposito.Text = "SACAR";
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel33_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
/*
static double somaSaldo;   //variavel global

double valor;
valor = double.Parse(txtValor.Text);
lblSaldoValor.Text = ("R$:" + valor);

lblSaldoValor.Text = "R$" + (somaSaldo + valor);
somaSaldo = somaSaldo + valor;
*/
