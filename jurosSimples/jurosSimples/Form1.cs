﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jurosSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double capital = Convert.ToDouble(tbxCapital.Text);
            double taxa = Convert.ToDouble(tbxTaxa.Text);
            double tempo = Convert.ToDouble(tbxTempo.Text);

            double juros = (capital * taxa * tempo) / 100;
            tbxJuros.Text = juros.ToString();
            
            double montante = capital + juros;
            tbxMontante.Text = montante.ToString();

        }
    }
}
