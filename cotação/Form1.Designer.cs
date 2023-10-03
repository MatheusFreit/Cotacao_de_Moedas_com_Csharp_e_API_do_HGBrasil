namespace cotação
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1moedas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblcompra = new System.Windows.Forms.Label();
            this.lblvenda = new System.Windows.Forms.Label();
            this.lblvariacao = new System.Windows.Forms.Label();
            this.btPesquisa = new System.Windows.Forms.Button();
            this.btlimpeza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-3, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "COTAÇÃO ATUAL ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Moeda:";
            // 
            // comboBox1moedas
            // 
            this.comboBox1moedas.FormattingEnabled = true;
            this.comboBox1moedas.Items.AddRange(new object[] {
            "Bitcoin",
            "Dólar ",
            "Euro"});
            this.comboBox1moedas.Location = new System.Drawing.Point(82, 99);
            this.comboBox1moedas.Name = "comboBox1moedas";
            this.comboBox1moedas.Size = new System.Drawing.Size(305, 21);
            this.comboBox1moedas.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(20, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Compra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(29, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Venda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(13, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Variação:";
            // 
            // lblcompra
            // 
            this.lblcompra.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblcompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblcompra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcompra.Location = new System.Drawing.Point(95, 162);
            this.lblcompra.Name = "lblcompra";
            this.lblcompra.Size = new System.Drawing.Size(292, 52);
            this.lblcompra.TabIndex = 6;
            this.lblcompra.Text = "0,0";
            this.lblcompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblvenda
            // 
            this.lblvenda.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblvenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblvenda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblvenda.Location = new System.Drawing.Point(95, 226);
            this.lblvenda.Name = "lblvenda";
            this.lblvenda.Size = new System.Drawing.Size(292, 52);
            this.lblvenda.TabIndex = 7;
            this.lblvenda.Text = "0,0";
            this.lblvenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblvariacao
            // 
            this.lblvariacao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblvariacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblvariacao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblvariacao.Location = new System.Drawing.Point(95, 298);
            this.lblvariacao.Name = "lblvariacao";
            this.lblvariacao.Size = new System.Drawing.Size(292, 52);
            this.lblvariacao.TabIndex = 8;
            this.lblvariacao.Text = "0,0";
            this.lblvariacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btPesquisa
            // 
            this.btPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btPesquisa.Location = new System.Drawing.Point(269, 390);
            this.btPesquisa.Name = "btPesquisa";
            this.btPesquisa.Size = new System.Drawing.Size(118, 32);
            this.btPesquisa.TabIndex = 9;
            this.btPesquisa.Text = "Pesquisar";
            this.btPesquisa.UseVisualStyleBackColor = true;
            this.btPesquisa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btlimpeza
            // 
            this.btlimpeza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btlimpeza.Location = new System.Drawing.Point(145, 390);
            this.btlimpeza.Name = "btlimpeza";
            this.btlimpeza.Size = new System.Drawing.Size(118, 32);
            this.btlimpeza.TabIndex = 10;
            this.btlimpeza.Text = "Limpar";
            this.btlimpeza.UseVisualStyleBackColor = true;
            this.btlimpeza.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 439);
            this.Controls.Add(this.btlimpeza);
            this.Controls.Add(this.btPesquisa);
            this.Controls.Add(this.lblvariacao);
            this.Controls.Add(this.lblvenda);
            this.Controls.Add(this.lblcompra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1moedas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(415, 478);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(415, 478);
            this.Name = "Form1";
            this.Text = "Cotação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1moedas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblcompra;
        private System.Windows.Forms.Label lblvenda;
        private System.Windows.Forms.Label lblvariacao;
        private System.Windows.Forms.Button btPesquisa;
        private System.Windows.Forms.Button btlimpeza;
    }
}

