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
        String[] palavras = { "carta", "vento", "pluma", "festa", 
            "nuvem", "tigre", "verde", "ramos", "folha", "bravo" };
        String termo;
        int contLinhas = 1;
        public Form1()
        {
            InitializeComponent();
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
            if (contLinhas == 1)
            {
                letras[0] = Convert.ToChar(tbx11.Text);
                letras[1] = Convert.ToChar(tbx12.Text);
                letras[2] = Convert.ToChar(tbx13.Text);
                letras[3] = Convert.ToChar(tbx14.Text);
                letras[4] = Convert.ToChar(tbx15.Text);

                //verificar letra por letra
                String[] gabarito = { "não", "não", "não", "não", "não" } ;
                //verificar se tem
                for (int i = 0; i < letras.Length; i++)
                {
                    for (int j = 0; j < termo.Length; j++)
                    {
                        if (letras[i] == termo[j])
                        {
                            gabarito[i] = "tem";
                        }
                    }
                }
                //verificar se a letra está no local correto
                for (int i = 0; i < letras.Length; i++)
                {
                    if (letras[i] == termo[i])
                    {
                        gabarito[i] = "correto";
                    }
                }
                //Mudar a cor
                if (gabarito[0] == "tem")
                {
                    tbx11.BackColor = Color.Yellow;
                }
                if (gabarito[0] == "correto")
                {
                    tbx11.BackColor = Color.Green;
                }

                if (gabarito[1] == "tem")
                {
                    tbx12.BackColor = Color.Yellow;
                }
                if (gabarito[1] == "correto")
                {
                    tbx12.BackColor = Color.Green;
                }

                if (gabarito[2] == "tem")
                {
                    tbx13.BackColor = Color.Yellow;
                }
                if (gabarito[2] == "correto")
                {
                    tbx13.BackColor = Color.Green;
                }

                if (gabarito[3] == "tem")
                {
                    tbx14.BackColor = Color.Yellow;
                }
                if (gabarito[3] == "correto")
                {
                    tbx14.BackColor = Color.Green;
                }

                if (gabarito[4] == "tem")
                {
                    tbx15.BackColor = Color.Yellow;
                }
                if (gabarito[4] == "correto")
                {
                    tbx15.BackColor = Color.Green;
                }

                //desbloquear os textboxs na 2a linha
                tbx21.Enabled = true;
                tbx22.Enabled = true;
                tbx23.Enabled = true;
                tbx24.Enabled = true;
                tbx25.Enabled = true;

            }
            //segunda linha
            if (contLinhas == 2)
            {
                
                letras[0] = Convert.ToChar(tbx21.Text);
                letras[1] = Convert.ToChar(tbx22.Text);
                letras[2] = Convert.ToChar(tbx23.Text);
                letras[3] = Convert.ToChar(tbx24.Text);
                letras[4] = Convert.ToChar(tbx25.Text);

                //verificar letra por letra
                String[] gabarito = { "não", "não", "não", "não", "não" };
                //verificar se tem
                for (int i = 0; i < letras.Length; i++)
                {
                    for (int j = 0; j < termo.Length; j++)
                    {
                        if (letras[i] == termo[j])
                        {
                            gabarito[i] = "tem";
                        }
                    }
                }
                //verificar se a letra está no local correto
                for (int i = 0; i < letras.Length; i++)
                {
                    if (letras[i] == termo[i])
                    {
                        gabarito[i] = "correto";
                    }
                }
                //Mudar a cor
                if (gabarito[0] == "tem")
                {
                    tbx21.BackColor = Color.Yellow;
                }
                if (gabarito[0] == "correto")
                {
                    tbx21.BackColor = Color.Green;
                }

                if (gabarito[1] == "tem")
                {
                    tbx22.BackColor = Color.Yellow;
                }
                if (gabarito[1] == "correto")
                {
                    tbx22.BackColor = Color.Green;
                }

                if (gabarito[2] == "tem")
                {
                    tbx23.BackColor = Color.Yellow;
                }
                if (gabarito[2] == "correto")
                {
                    tbx23.BackColor = Color.Green;
                }

                if (gabarito[3] == "tem")
                {
                    tbx24.BackColor = Color.Yellow;
                }
                if (gabarito[3] == "correto")
                {
                    tbx24.BackColor = Color.Green;
                }

                if (gabarito[4] == "tem")
                {
                    tbx25.BackColor = Color.Yellow;
                }
                if (gabarito[4] == "correto")
                {
                    tbx25.BackColor = Color.Green;
                }
                //desbloquear a linha 3
                tbx31.Enabled = true;
                tbx32.Enabled = true;
                tbx33.Enabled = true;
                tbx34.Enabled = true;
                tbx35.Enabled = true;
            }

            //terceira linha
            if (contLinhas == 3)
            {

                letras[0] = Convert.ToChar(tbx31.Text);
                letras[1] = Convert.ToChar(tbx32.Text);
                letras[2] = Convert.ToChar(tbx33.Text);
                letras[3] = Convert.ToChar(tbx34.Text);
                letras[4] = Convert.ToChar(tbx35.Text);

                //verificar letra por letra
                String[] gabarito = { "não", "não", "não", "não", "não" };
                //verificar se tem
                for (int i = 0; i < letras.Length; i++)
                {
                    for (int j = 0; j < termo.Length; j++)
                    {
                        if (letras[i] == termo[j])
                        {
                            gabarito[i] = "tem";
                        }
                    }
                }
                //verificar se a letra está no local correto
                for (int i = 0; i < letras.Length; i++)
                {
                    if (letras[i] == termo[i])
                    {
                        gabarito[i] = "correto";
                    }
                }
                //Mudar a cor
                if (gabarito[0] == "tem")
                {
                    tbx31.BackColor = Color.Yellow;
                }
                if (gabarito[0] == "correto")
                {
                    tbx31.BackColor = Color.Green;
                }

                if (gabarito[1] == "tem")
                {
                    tbx32.BackColor = Color.Yellow;
                }
                if (gabarito[1] == "correto")
                {
                    tbx32.BackColor = Color.Green;
                }

                if (gabarito[2] == "tem")
                {
                    tbx33.BackColor = Color.Yellow;
                }
                if (gabarito[2] == "correto")
                {
                    tbx33.BackColor = Color.Green;
                }

                if (gabarito[3] == "tem")
                {
                    tbx34.BackColor = Color.Yellow;
                }
                if (gabarito[3] == "correto")
                {
                    tbx34.BackColor = Color.Green;
                }

                if (gabarito[4] == "tem")
                {
                    tbx35.BackColor = Color.Yellow;
                }
                if (gabarito[4] == "correto")
                {
                    tbx35.BackColor = Color.Green;
                }
                //desbloquear a linha 4
                tbx41.Enabled = true;
                tbx42.Enabled = true;
                tbx43.Enabled = true;
                tbx44.Enabled = true;
                tbx45.Enabled = true;
            }
            //quarta linha
            if (contLinhas == 4)
            {

                letras[0] = Convert.ToChar(tbx41.Text);
                letras[1] = Convert.ToChar(tbx42.Text);
                letras[2] = Convert.ToChar(tbx43.Text);
                letras[3] = Convert.ToChar(tbx44.Text);
                letras[4] = Convert.ToChar(tbx45.Text);

                //verificar letra por letra
                String[] gabarito = { "não", "não", "não", "não", "não" };
                //verificar se tem
                for (int i = 0; i < letras.Length; i++)
                {
                    for (int j = 0; j < termo.Length; j++)
                    {
                        if (letras[i] == termo[j])
                        {
                            gabarito[i] = "tem";
                        }
                    }
                }
                //verificar se a letra está no local correto
                for (int i = 0; i < letras.Length; i++)
                {
                    if (letras[i] == termo[i])
                    {
                        gabarito[i] = "correto";
                    }
                }
                //Mudar a cor
                if (gabarito[0] == "tem")
                {
                    tbx41.BackColor = Color.Yellow;
                }
                if (gabarito[0] == "correto")
                {
                    tbx41.BackColor = Color.Green;
                }

                if (gabarito[1] == "tem")
                {
                    tbx42.BackColor = Color.Yellow;
                }
                if (gabarito[1] == "correto")
                {
                    tbx42.BackColor = Color.Green;
                }

                if (gabarito[2] == "tem")
                {
                    tbx43.BackColor = Color.Yellow;
                }
                if (gabarito[2] == "correto")
                {
                    tbx43.BackColor = Color.Green;
                }

                if (gabarito[3] == "tem")
                {
                    tbx44.BackColor = Color.Yellow;
                }
                if (gabarito[3] == "correto")
                {
                    tbx44.BackColor = Color.Green;
                }

                if (gabarito[4] == "tem")
                {
                    tbx45.BackColor = Color.Yellow;
                }
                if (gabarito[4] == "correto")
                {
                    tbx45.BackColor = Color.Green;
                }
                //desbloquear a linha 5
                tbx51.Enabled = true;
                tbx52.Enabled = true;
                tbx53.Enabled = true;
                tbx54.Enabled = true;
                tbx55.Enabled = true;
            }

            //quinta linha
            if (contLinhas == 5)
            {

                letras[0] = Convert.ToChar(tbx51.Text);
                letras[1] = Convert.ToChar(tbx52.Text);
                letras[2] = Convert.ToChar(tbx53.Text);
                letras[3] = Convert.ToChar(tbx54.Text);
                letras[4] = Convert.ToChar(tbx55.Text);

                //verificar letra por letra
                String[] gabarito = { "não", "não", "não", "não", "não" };
                //verificar se tem
                for (int i = 0; i < letras.Length; i++)
                {
                    for (int j = 0; j < termo.Length; j++)
                    {
                        if (letras[i] == termo[j])
                        {
                            gabarito[i] = "tem";
                        }
                    }
                }
                //verificar se a letra está no local correto
                for (int i = 0; i < letras.Length; i++)
                {
                    if (letras[i] == termo[i])
                    {
                        gabarito[i] = "correto";
                    }
                }
                //Mudar a cor
                if (gabarito[0] == "tem")
                {
                    tbx51.BackColor = Color.Yellow;
                }
                if (gabarito[0] == "correto")
                {
                    tbx51.BackColor = Color.Green;
                }

                if (gabarito[1] == "tem")
                {
                    tbx52.BackColor = Color.Yellow;
                }
                if (gabarito[1] == "correto")
                {
                    tbx52.BackColor = Color.Green;
                }

                if (gabarito[2] == "tem")
                {
                    tbx53.BackColor = Color.Yellow;
                }
                if (gabarito[2] == "correto")
                {
                    tbx53.BackColor = Color.Green;
                }

                if (gabarito[3] == "tem")
                {
                    tbx54.BackColor = Color.Yellow;
                }
                if (gabarito[3] == "correto")
                {
                    tbx54.BackColor = Color.Green;
                }

                if (gabarito[4] == "tem")
                {
                    tbx55.BackColor = Color.Yellow;
                }
                if (gabarito[4] == "correto")
                {
                    tbx55.BackColor = Color.Green;
                }
                //desbloquear a linha 6
                tbx61.Enabled = true;
                tbx62.Enabled = true;
                tbx63.Enabled = true;
                tbx64.Enabled = true;
                tbx65.Enabled = true;
            }
            //sexta linha
            if (contLinhas == 6)
            {

                letras[0] = Convert.ToChar(tbx61.Text);
                letras[1] = Convert.ToChar(tbx62.Text);
                letras[2] = Convert.ToChar(tbx63.Text);
                letras[3] = Convert.ToChar(tbx64.Text);
                letras[4] = Convert.ToChar(tbx65.Text);

                //verificar letra por letra
                String[] gabarito = { "não", "não", "não", "não", "não" };
                //verificar se tem
                for (int i = 0; i < letras.Length; i++)
                {
                    for (int j = 0; j < termo.Length; j++)
                    {
                        if (letras[i] == termo[j])
                        {
                            gabarito[i] = "tem";
                        }
                    }
                }
                //verificar se a letra está no local correto
                for (int i = 0; i < letras.Length; i++)
                {
                    if (letras[i] == termo[i])
                    {
                        gabarito[i] = "correto";
                    }
                }
                //Mudar a cor
                if (gabarito[0] == "tem")
                {
                    tbx61.BackColor = Color.Yellow;
                }
                if (gabarito[0] == "correto")
                {
                    tbx61.BackColor = Color.Green;
                }

                if (gabarito[1] == "tem")
                {
                    tbx62.BackColor = Color.Yellow;
                }
                if (gabarito[1] == "correto")
                {
                    tbx62.BackColor = Color.Green;
                }

                if (gabarito[2] == "tem")
                {
                    tbx63.BackColor = Color.Yellow;
                }
                if (gabarito[2] == "correto")
                {
                    tbx63.BackColor = Color.Green;
                }

                if (gabarito[3] == "tem")
                {
                    tbx64.BackColor = Color.Yellow;
                }
                if (gabarito[3] == "correto")
                {
                    tbx64.BackColor = Color.Green;
                }

                if (gabarito[4] == "tem")
                {
                    tbx65.BackColor = Color.Yellow;
                }
                if (gabarito[4] == "correto")
                {
                    tbx65.BackColor = Color.Green;
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
            else if(contLinhas < 6)
            {
                contLinhas++;
            }
            else
            {
                MessageBox.Show("Você perdeu", "Termo");
            }
        }
    }
}
