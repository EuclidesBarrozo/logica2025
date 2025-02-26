using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(tbxNota1.Text);
            double n2 = Convert.ToDouble(tbxNota2.Text);
            double n3 = Convert.ToDouble(tbxNota3.Text);

            double media = (n1 + n2 + n3) / 3;

            if (media >= 7)
            {
                lblResultado.ForeColor = Color.Blue;
                lblResultado.Text = " Resultado: Aprovado";
                pictureBox1.Image = Properties.Resources.aprovado;
                pictureBox1.Visible = true;
            }
            if(media < 7)
            {
                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = " Resultado: Reprovado";
                pictureBox1.Image = Properties.Resources.reprovado;
                pictureBox1.Visible = true;
            }
        }
    }
}
