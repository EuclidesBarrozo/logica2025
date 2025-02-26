using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnaliseClima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //guardar o nome da cidade (variável)
            String nome = tbxCidade.Text;
            //guardar a quantidade de dias (variável)
            int qtd = Convert.ToInt32(tbxQuantidade.Text);
            //criar um vetor do tamanho da quantidade de dias
            int[] temperaturas = new int[qtd];
            //gerar dados aleatório que represente a temperatura
            //desses dias e armazenar no vetor
            //for(inicialização;condição;incremento)
            Random random = new Random();
            for (int cont = 0;  cont < qtd; cont++)
            {
                //gera uma temperatura aleatória entre 15 e 40
                int temp = random.Next(15, 41);
                temperaturas[cont] = temp;
            }
            //calcular a média das temperaturas
            int soma = 0;
            for(int cont = 0;cont < qtd; cont++)
            {
                soma = soma + temperaturas[cont];
            }
            double media = soma/ qtd;

            //escrever os números na lblNúmeros
            String lista = "";
            for(int cont = 0; cont < qtd; cont++)
            {
                lista = lista + temperaturas[cont].ToString() + " ";
            }
            lblNumeros.Text = lista;
            //exibir a média
            MessageBox.Show("Média de temperatura: " + media, "Análise de Clima", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
