using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recuperação
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblRecuperacao.Visible = false;
            tbxRecuperacao.Visible = false;
            btnRecuperacao.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(tbxN1.Text);
            double nota2 = Convert.ToDouble(tbxN2.Text);
            double nota3 = Convert.ToDouble(tbxN3.Text);

            double media = (nota1 + nota2 + nota3) / 3;
            tbxMedia.Text = Math.Round(media, 2).ToString();
            //reprovado
            if (media < 4)
            {
                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = "Reprovado.";             
            }
            if(media >= 4 && media < 7)
            {
                lblResultado.ForeColor = Color.Orange;
                lblResultado.Text = "Recuperação.";
                lblRecuperacao.Visible = true;
                tbxRecuperacao.Visible = true;
                btnRecuperacao.Visible = true;
            }
            if(media >= 7)
            {
                lblResultado.ForeColor = Color.Green;
                lblResultado.Text = "Aprovado.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //media + notaRecuperação >= 10
            double media = Convert.ToDouble(tbxMedia.Text);
            double notaR = Convert.ToDouble(tbxRecuperacao.Text);

            double total = media + notaR;
            if(total >= 10)
            {
                lblResultado.ForeColor = Color.Green;
                lblResultado.Text = "Aprovado.";
            }
            else
            {
                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = "Reprovado.";
            }
        }
    }
}
