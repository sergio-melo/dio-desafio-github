namespace ConsultaAPI
{
    partial class FrmMain
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
            this.texCEP = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textComp1 = new System.Windows.Forms.TextBox();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.textBairro = new System.Windows.Forms.TextBox();
            this.textUf = new System.Windows.Forms.TextBox();
            this.textComp2 = new System.Windows.Forms.TextBox();
            this.textPostagem = new System.Windows.Forms.TextBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CEP:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // texCEP
            // 
            this.texCEP.Location = new System.Drawing.Point(49, 57);
            this.texCEP.Name = "texCEP";
            this.texCEP.Size = new System.Drawing.Size(117, 20);
            this.texCEP.TabIndex = 1;
            this.texCEP.TextChanged += new System.EventHandler(this.texCEP_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(349, 55);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(199, 55);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(111, 22);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(699, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(306, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cidade:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "endereço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Complemento 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Complemento 2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label7.Location = new System.Drawing.Point(518, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Bairro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(518, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Unidade Postagem:";
            // 
            // textComp1
            // 
            this.textComp1.Location = new System.Drawing.Point(98, 163);
            this.textComp1.Name = "textComp1";
            this.textComp1.Size = new System.Drawing.Size(173, 20);
            this.textComp1.TabIndex = 1;
            // 
            // textCidade
            // 
            this.textCidade.Location = new System.Drawing.Point(366, 118);
            this.textCidade.Name = "textCidade";
            this.textCidade.Size = new System.Drawing.Size(127, 20);
            this.textCidade.TabIndex = 1;
            // 
            // textBairro
            // 
            this.textBairro.Location = new System.Drawing.Point(570, 120);
            this.textBairro.Name = "textBairro";
            this.textBairro.Size = new System.Drawing.Size(106, 20);
            this.textBairro.TabIndex = 1;
            // 
            // textUf
            // 
            this.textUf.Location = new System.Drawing.Point(764, 118);
            this.textUf.Name = "textUf";
            this.textUf.Size = new System.Drawing.Size(66, 20);
            this.textUf.TabIndex = 1;
            // 
            // textComp2
            // 
            this.textComp2.Location = new System.Drawing.Point(366, 163);
            this.textComp2.Name = "textComp2";
            this.textComp2.Size = new System.Drawing.Size(127, 20);
            this.textComp2.TabIndex = 1;
            // 
            // textPostagem
            // 
            this.textPostagem.Location = new System.Drawing.Point(624, 163);
            this.textPostagem.Name = "textPostagem";
            this.textPostagem.Size = new System.Drawing.Size(127, 20);
            this.textPostagem.TabIndex = 1;
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(86, 121);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(203, 20);
            this.textEndereco.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 402);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.textUf);
            this.Controls.Add(this.textBairro);
            this.Controls.Add(this.textCidade);
            this.Controls.Add(this.textComp2);
            this.Controls.Add(this.textPostagem);
            this.Controls.Add(this.textComp1);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.texCEP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMain";
            this.Text = "ConsultaCep";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texCEP;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textComp1;
        private System.Windows.Forms.TextBox textCidade;
        private System.Windows.Forms.TextBox textBairro;
        private System.Windows.Forms.TextBox textUf;
        private System.Windows.Forms.TextBox textComp2;
        private System.Windows.Forms.TextBox textPostagem;
        private System.Windows.Forms.TextBox textEndereco;
    }
}

