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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usuario = tbxUsuario.Text;
            String senha   = tbxSenha.Text;

            if(senha == "1234")
            {
                Inicio i = new Inicio(usuario, this);
                i.Show();
                lblSenhaIncorreta.Visible = false;
            }
            else
            {
                //mensagem de senha incorreta ficará visível
                lblSenhaIncorreta.Visible = true;
            }
        }
    }
}
