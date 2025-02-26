namespace investimento
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
            this.cbxInvestimento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblRendimento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxInvestimento
            // 
            this.cbxInvestimento.FormattingEnabled = true;
            this.cbxInvestimento.Items.AddRange(new object[] {
            "Poupança",
            "Renda Fixa"});
            this.cbxInvestimento.Location = new System.Drawing.Point(149, 52);
            this.cbxInvestimento.Name = "cbxInvestimento";
            this.cbxInvestimento.Size = new System.Drawing.Size(121, 21);
            this.cbxInvestimento.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Investimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor";
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(149, 99);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(121, 20);
            this.tbxValor.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRendimento
            // 
            this.lblRendimento.AutoSize = true;
            this.lblRendimento.Location = new System.Drawing.Point(146, 191);
            this.lblRendimento.Name = "lblRendimento";
            this.lblRendimento.Size = new System.Drawing.Size(35, 13);
            this.lblRendimento.TabIndex = 5;
            this.lblRendimento.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRendimento);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxInvestimento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxInvestimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRendimento;
    }
}

