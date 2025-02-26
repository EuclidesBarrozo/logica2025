using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pegar o valor do textbox tbxN1
            double n1 = Convert.ToDouble(tbxN1.Text);
            //pegar o valor do textbox tbxN2
            double n2 = Convert.ToDouble(tbxN2.Text);
            //somar 
            double resultado = n1 + n2;
            //inserir o resultado no tbxResultado
            tbxResultado.Text = resultado.ToString();
        }
    }
}
