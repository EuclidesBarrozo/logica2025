namespace notas
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
            this.tbxN1 = new System.Windows.Forms.TextBox();
            this.tbxN2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxN3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota 1";
            // 
            // tbxN1
            // 
            this.tbxN1.Location = new System.Drawing.Point(152, 47);
            this.tbxN1.Name = "tbxN1";
            this.tbxN1.Size = new System.Drawing.Size(100, 20);
            this.tbxN1.TabIndex = 1;
            // 
            // tbxN2
            // 
            this.tbxN2.Location = new System.Drawing.Point(152, 92);
            this.tbxN2.Name = "tbxN2";
            this.tbxN2.Size = new System.Drawing.Size(100, 20);
            this.tbxN2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota 2";
            // 
            // tbxN3
            // 
            this.tbxN3.Location = new System.Drawing.Point(152, 137);
            this.tbxN3.Name = "tbxN3";
            this.tbxN3.Size = new System.Drawing.Size(100, 20);
            this.tbxN3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota 3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Maior número";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(149, 196);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Resultado";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Menor número";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(296, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Soma";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 365);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxN3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxN2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxN1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxN1;
        private System.Windows.Forms.TextBox tbxN2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxN3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

