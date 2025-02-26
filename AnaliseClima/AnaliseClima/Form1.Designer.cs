namespace AnaliseClima
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
            this.tbxCidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxQuantidade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNumeros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Análise de Clima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cidade";
            // 
            // tbxCidade
            // 
            this.tbxCidade.Location = new System.Drawing.Point(137, 64);
            this.tbxCidade.Name = "tbxCidade";
            this.tbxCidade.Size = new System.Drawing.Size(243, 20);
            this.tbxCidade.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantidade de dias";
            // 
            // tbxQuantidade
            // 
            this.tbxQuantidade.Location = new System.Drawing.Point(137, 103);
            this.tbxQuantidade.Name = "tbxQuantidade";
            this.tbxQuantidade.Size = new System.Drawing.Size(243, 20);
            this.tbxQuantidade.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Média";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNumeros
            // 
            this.lblNumeros.AutoSize = true;
            this.lblNumeros.Location = new System.Drawing.Point(22, 203);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(52, 13);
            this.lblNumeros.TabIndex = 6;
            this.lblNumeros.Text = "Números:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 245);
            this.Controls.Add(this.lblNumeros);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxQuantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxCidade);
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
        private System.Windows.Forms.TextBox tbxCidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxQuantidade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNumeros;
    }
}

