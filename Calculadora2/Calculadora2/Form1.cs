using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String operador = cbxOperador.Text;
            double n1 = Convert.ToDouble(tbxN1.Text);
            double n2 = Convert.ToDouble(tbxN2.Text);
            double resultado = 0;

            if (operador == "soma") 
                resultado = n1 + n2;
            if (operador == "subtração")
                resultado = n1 - n2;
            if (operador == "multiplicação")
                resultado = n1 * n2;
            if (operador == "divisão")
                resultado = n1 / n2;

            tbxResultado.Text = resultado.ToString();
        }
    }
}
