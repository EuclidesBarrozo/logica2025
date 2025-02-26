using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Inicio : Form
    {
        public Inicio(String usuario, Form1 f)
        {
            InitializeComponent();
            lblMensagem.Text = "Bem-vindo " + usuario;
            //Form1 f = new Form1();
            //f.Visible = false;
            
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
