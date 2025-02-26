namespace recuperação
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.tbxN1 = new System.Windows.Forms.TextBox();
            this.tbxN2 = new System.Windows.Forms.TextBox();
            this.tbxN3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRecuperacao = new System.Windows.Forms.Button();
            this.tbxRecuperacao = new System.Windows.Forms.TextBox();
            this.lblRecuperacao = new System.Windows.Forms.Label();
            this.tbxMedia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota3";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(96, 237);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 3;
            // 
            // tbxN1
            // 
            this.tbxN1.Location = new System.Drawing.Point(146, 38);
            this.tbxN1.Name = "tbxN1";
            this.tbxN1.Size = new System.Drawing.Size(131, 20);
            this.tbxN1.TabIndex = 4;
            // 
            // tbxN2
            // 
            this.tbxN2.Location = new System.Drawing.Point(146, 76);
            this.tbxN2.Name = "tbxN2";
            this.tbxN2.Size = new System.Drawing.Size(131, 20);
            this.tbxN2.TabIndex = 5;
            // 
            // tbxN3
            // 
            this.tbxN3.Location = new System.Drawing.Point(146, 107);
            this.tbxN3.Name = "tbxN3";
            this.tbxN3.Size = new System.Drawing.Size(131, 20);
            this.tbxN3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRecuperacao
            // 
            this.btnRecuperacao.Location = new System.Drawing.Point(471, 79);
            this.btnRecuperacao.Name = "btnRecuperacao";
            this.btnRecuperacao.Size = new System.Drawing.Size(75, 23);
            this.btnRecuperacao.TabIndex = 10;
            this.btnRecuperacao.Text = "Calcular";
            this.btnRecuperacao.UseVisualStyleBackColor = true;
            this.btnRecuperacao.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbxRecuperacao
            // 
            this.tbxRecuperacao.Location = new System.Drawing.Point(447, 39);
            this.tbxRecuperacao.Name = "tbxRecuperacao";
            this.tbxRecuperacao.Size = new System.Drawing.Size(131, 20);
            this.tbxRecuperacao.TabIndex = 9;
            // 
            // lblRecuperacao
            // 
            this.lblRecuperacao.AutoSize = true;
            this.lblRecuperacao.Location = new System.Drawing.Point(369, 48);
            this.lblRecuperacao.Name = "lblRecuperacao";
            this.lblRecuperacao.Size = new System.Drawing.Size(72, 13);
            this.lblRecuperacao.TabIndex = 8;
            this.lblRecuperacao.Text = "Recuperação";
            // 
            // tbxMedia
            // 
            this.tbxMedia.Location = new System.Drawing.Point(146, 183);
            this.tbxMedia.Name = "tbxMedia";
            this.tbxMedia.Size = new System.Drawing.Size(131, 20);
            this.tbxMedia.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Média";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 284);
            this.Controls.Add(this.tbxMedia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRecuperacao);
            this.Controls.Add(this.tbxRecuperacao);
            this.Controls.Add(this.lblRecuperacao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxN3);
            this.Controls.Add(this.tbxN2);
            this.Controls.Add(this.tbxN1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox tbxN1;
        private System.Windows.Forms.TextBox tbxN2;
        private System.Windows.Forms.TextBox tbxN3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRecuperacao;
        private System.Windows.Forms.TextBox tbxRecuperacao;
        private System.Windows.Forms.Label lblRecuperacao;
        private System.Windows.Forms.TextBox tbxMedia;
        private System.Windows.Forms.Label label4;
    }
}

