using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace detetive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cont = 0;
            if (cbP1.Checked) { cont++; }
            if (cbP2.Checked) { cont++; }
            if (cbP3.Checked) { cont++; }
            if (cbP4.Checked) { cont++; }
            if (cbP5.Checked) { cont++; }

            switch (cont) 
            {
                case 0: 
                    lblResultado.Text = "Inocente";
                    pictureBox1.Image = Properties.Resources.inocente;
                    break;
                case 1:
                    lblResultado.Text = "Inocente";
                    pictureBox1.Image = Properties.Resources.inocente;
                    break;
                case 2:
                    lblResultado.Text = "Suspeito";
                    pictureBox1.Image = Properties.Resources.suspeito;
                    break;
                case 3:
                    lblResultado.Text = "Cúmplice";
                    pictureBox1.Image = Properties.Resources.cumplice;
                    break;
                case 4:
                    lblResultado.Text = "Cúmplice";
                    pictureBox1.Image = Properties.Resources.cumplice;
                    break;
                case 5:
                    lblResultado.Text = "ASSASSINO";
                    pictureBox1.Image = Properties.Resources.assassino;
                    break;
                default:
                    lblResultado.Text = "Erro";
                    break;
            }

        }
    }
}
