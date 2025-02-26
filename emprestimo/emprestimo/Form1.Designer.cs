namespace emprestimo
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
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxScore = new System.Windows.Forms.TextBox();
            this.tbxRenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbId1 = new System.Windows.Forms.RadioButton();
            this.rbId2 = new System.Windows.Forms.RadioButton();
            this.rbId3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb1ano = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxNP = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Análise de crédito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor do Emprétimo";
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(141, 60);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(165, 20);
            this.tbxValor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Score";
            // 
            // tbxScore
            // 
            this.tbxScore.Location = new System.Drawing.Point(141, 158);
            this.tbxScore.Name = "tbxScore";
            this.tbxScore.Size = new System.Drawing.Size(165, 20);
            this.tbxScore.TabIndex = 4;
            // 
            // tbxRenda
            // 
            this.tbxRenda.Location = new System.Drawing.Point(141, 209);
            this.tbxRenda.Name = "tbxRenda";
            this.tbxRenda.Size = new System.Drawing.Size(165, 20);
            this.tbxRenda.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Renda Mensal";
            // 
            // rbId1
            // 
            this.rbId1.AutoSize = true;
            this.rbId1.Location = new System.Drawing.Point(57, 34);
            this.rbId1.Name = "rbId1";
            this.rbId1.Size = new System.Drawing.Size(89, 17);
            this.rbId1.TabIndex = 7;
            this.rbId1.TabStop = true;
            this.rbId1.Text = "Entre 14 e 20";
            this.rbId1.UseVisualStyleBackColor = true;
            // 
            // rbId2
            // 
            this.rbId2.AutoSize = true;
            this.rbId2.Location = new System.Drawing.Point(57, 68);
            this.rbId2.Name = "rbId2";
            this.rbId2.Size = new System.Drawing.Size(89, 17);
            this.rbId2.TabIndex = 8;
            this.rbId2.TabStop = true;
            this.rbId2.Text = "Entre 21 e 65";
            this.rbId2.UseVisualStyleBackColor = true;
            // 
            // rbId3
            // 
            this.rbId3.AutoSize = true;
            this.rbId3.Location = new System.Drawing.Point(57, 101);
            this.rbId3.Name = "rbId3";
            this.rbId3.Size = new System.Drawing.Size(110, 17);
            this.rbId3.TabIndex = 9;
            this.rbId3.TabStop = true;
            this.rbId3.Text = "Acima de 65 anos";
            this.rbId3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbId2);
            this.groupBox1.Controls.Add(this.rbId3);
            this.groupBox1.Controls.Add(this.rbId1);
            this.groupBox1.Location = new System.Drawing.Point(90, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 145);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Faixa Etária";
            // 
            // cb1ano
            // 
            this.cb1ano.AutoSize = true;
            this.cb1ano.Location = new System.Drawing.Point(90, 420);
            this.cb1ano.Name = "cb1ano";
            this.cb1ano.Size = new System.Drawing.Size(213, 17);
            this.cb1ano.TabIndex = 11;
            this.cb1ano.Text = "Está a mais de 1 ano no atual emprego.";
            this.cb1ano.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Analisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Número de Parcelas";
            // 
            // cbxNP
            // 
            this.cbxNP.FormattingEnabled = true;
            this.cbxNP.Items.AddRange(new object[] {
            "12",
            "24",
            "36",
            "48"});
            this.cbxNP.Location = new System.Drawing.Point(141, 108);
            this.cbxNP.Name = "cbxNP";
            this.cbxNP.Size = new System.Drawing.Size(165, 21);
            this.cbxNP.TabIndex = 14;
            this.cbxNP.Text = "48";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 515);
            this.Controls.Add(this.cbxNP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb1ano);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxRenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxScore;
        private System.Windows.Forms.TextBox tbxRenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbId1;
        private System.Windows.Forms.RadioButton rbId2;
        private System.Windows.Forms.RadioButton rbId3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb1ano;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxNP;
    }
}

