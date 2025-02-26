using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emprestimo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(tbxValor.Text);
            double score = Convert.ToDouble(tbxScore.Text);


            if(score > 700)
            {
                double NP = Convert.ToDouble(cbxNP.Text);
                double renda = Convert.ToDouble(tbxRenda.Text);
                //calcular o montante a 5% a.m. utilizando juros compostos
                // M = C * (1 + I)^T
                double montante = valor * Math.Pow(1 + 0.05, NP);
                double valorParcela = montante / NP;
                
                if(renda > 3 * valorParcela)
                {
                    if (rbId2.Checked)
                    {
                        if(cb1ano.Checked)
                        {
                            MessageBox.Show("Empréstimo aprovado!", "Análise Crédito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Empréstimo negado!", "Análise Crédito",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Empréstimo negado!", "Análise Crédito",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empréstimo negado!", "Análise Crédito",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Empréstimo negado!", "Análise Crédito", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
