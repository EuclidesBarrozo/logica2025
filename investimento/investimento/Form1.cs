using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace investimento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String investimento = cbxInvestimento.Text;
            Double valor = Convert.ToDouble(tbxValor.Text);
            Double rendimento = 0;
            if(investimento == "Poupança")
            {
                rendimento = valor * (3.0 / 100);
            }
            else
            {
                rendimento = valor * (4.0 / 100);
            }
            lblRendimento.Text = "Rendimento: " + rendimento.ToString();
        }
    }
}
