using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace termo
{
    public partial class Form1 : Form
    {
        //vetor de com 10 palavras
        String[] palavras = { "carta", "vento", "pluma", "festa", "nuvem", "tigre", "verde", "ramos", "folha", "bravo" };
        String termo;
        int contLinhas = 0;
        TextBox[,] textBoxes = new TextBox[6, 5];

        public Form1()
        {
            InitializeComponent();
            textBoxes[0, 0] = tbx11;
            textBoxes[0, 1] = tbx12;
            textBoxes[0, 2] = tbx13;
            textBoxes[0, 3] = tbx14;
            textBoxes[0, 4] = tbx15;
            textBoxes[1, 0] = tbx21;
            textBoxes[1, 1] = tbx22;
            textBoxes[1, 2] = tbx23;
            textBoxes[1, 3] = tbx24;
            textBoxes[1, 4] = tbx25;
            textBoxes[2, 0] = tbx31;
            textBoxes[2, 1] = tbx32;
            textBoxes[2, 2] = tbx33;
            textBoxes[2, 3] = tbx34;
            textBoxes[2, 4] = tbx35;
            textBoxes[3, 0] = tbx41;
            textBoxes[3, 1] = tbx42;
            textBoxes[3, 2] = tbx43;
            textBoxes[3, 3] = tbx44;
            textBoxes[3, 4] = tbx45;
            textBoxes[4, 0] = tbx51;
            textBoxes[4, 1] = tbx52;
            textBoxes[4, 2] = tbx53;
            textBoxes[4, 3] = tbx54;
            textBoxes[4, 4] = tbx55;
            textBoxes[5, 0] = tbx61;
            textBoxes[5, 1] = tbx62;
            textBoxes[5, 2] = tbx63;
            textBoxes[5, 3] = tbx64;
            textBoxes[5, 4] = tbx65;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //gerar número aleátorio entre 0 e 9
            Random random = new Random();
            int i = random.Next(0, 10);
            //definir o termo
            termo = palavras[i];
            lblTeste.Text = termo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Char[] letras = new Char[5];
            
                for(int i = 0; i < 5; i++)
                {
                    letras[i] = Convert.ToChar(textBoxes[contLinhas,i].Text);
                }
                
                //verificar se tem
                for (int i = 0; i < letras.Length; i++)
                {
                    for (int j = 0; j < termo.Length; j++)
                    {
                        if (letras[i] == termo[j])
                        {
                            textBoxes[contLinhas, i].BackColor = Color.Yellow;
                        }
                    }
                }
                //verificar se a letra está no local correto
                for (int i = 0; i < letras.Length; i++)
                {
                    if (letras[i] == termo[i])
                    {
                        textBoxes[contLinhas, i].BackColor = Color.Green;
                    }
                }

            //verificar se ganhou
            int acertos = 0;
            for(int i = 0; i < letras.Length; i++)
            {
                if (letras[i] == termo[i])
                {
                    acertos++;
                }
            }
            if(acertos == 5) 
            {
                MessageBox.Show("Você ganhou", "Termo");
            }
            else if(contLinhas < 5)
            {
                contLinhas++;
                for(int i = 0;i < 5; i++)
                {
                    textBoxes[contLinhas,i].Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Você perdeu", "Termo");
            }
        }
    }
}
