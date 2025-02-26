using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarme
{
    public partial class Form1 : Form
    {
        private DateTime horarioAlarme; // Variável para armazenar o horário do alarme
        private bool alarmeAtivado = false; // Indica se o alarme está ativado
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000; // Verifica a cada 1 segundo
            //timer1.Tick += timer1_Tick; // Associa o evento Tick
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            horarioAlarme = dateTimePicker1.Value;
            alarmeAtivado = true;
            lblStatus.Text = "Alarme definido para: " + horarioAlarme.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (alarmeAtivado && DateTime.Now >= horarioAlarme)
            {
                alarmeAtivado = false;
                lblStatus.Text = "Alarme Disparado!";

                // Tocar um som de alarme (use um arquivo .wav válido)
                try
                {
                    //SoundPlayer player = new SoundPlayer(@"C:\Windows\Media\Alarm01.wav");
                    //player.Play();
                    //MessageBox.Show("Hora do Alarme!", "Alarme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tocar som: " + ex.Message);
                }

                MessageBox.Show("Hora do Alarme!", "Alarme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
