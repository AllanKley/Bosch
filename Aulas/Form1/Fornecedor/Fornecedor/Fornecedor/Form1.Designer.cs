
namespace Fornecedor
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
            this.txbie = new System.Windows.Forms.MaskedTextBox();
            this.txbcpf = new System.Windows.Forms.MaskedTextBox();
            this.txbcnpj = new System.Windows.Forms.MaskedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txbtelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.btnfornecedor = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txbcidade2 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txbbairro2 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txblog2 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txbcod3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbie
            // 
            this.txbie.Location = new System.Drawing.Point(71, 330);
            this.txbie.Mask = "00.000.0000-0";
            this.txbie.Name = "txbie";
            this.txbie.Size = new System.Drawing.Size(190, 20);
            this.txbie.TabIndex = 141;
            // 
            // txbcpf
            // 
            this.txbcpf.Location = new System.Drawing.Point(71, 208);
            this.txbcpf.Mask = "000. 000.000-00";
            this.txbcpf.Name = "txbcpf";
            this.txbcpf.Size = new System.Drawing.Size(190, 20);
            this.txbcpf.TabIndex = 140;
            // 
            // txbcnpj
            // 
            this.txbcnpj.Location = new System.Drawing.Point(71, 266);
            this.txbcnpj.Mask = "00. 000.000/0000-00";
            this.txbcnpj.Name = "txbcnpj";
            this.txbcnpj.Size = new System.Drawing.Size(190, 20);
            this.txbcnpj.TabIndex = 139;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(68, 250);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 13);
            this.label23.TabIndex = 138;
            this.label23.Text = "CNPJ";
            // 
            // txbtelefone2
            // 
            this.txbtelefone2.Location = new System.Drawing.Point(313, 330);
            this.txbtelefone2.Mask = "(99) 00000-0000";
            this.txbtelefone2.Name = "txbtelefone2";
            this.txbtelefone2.Size = new System.Drawing.Size(190, 20);
            this.txbtelefone2.TabIndex = 137;
            // 
            // btnfornecedor
            // 
            this.btnfornecedor.BackColor = System.Drawing.Color.LimeGreen;
            this.btnfornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfornecedor.Location = new System.Drawing.Point(201, 378);
            this.btnfornecedor.Name = "btnfornecedor";
            this.btnfornecedor.Size = new System.Drawing.Size(188, 30);
            this.btnfornecedor.TabIndex = 129;
            this.btnfornecedor.Text = "Enviar";
            this.btnfornecedor.UseVisualStyleBackColor = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(310, 314);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 13);
            this.label24.TabIndex = 136;
            this.label24.Text = "Telefone";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(310, 250);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(40, 13);
            this.label25.TabIndex = 135;
            this.label25.Text = "Cidade";
            // 
            // txbcidade2
            // 
            this.txbcidade2.Location = new System.Drawing.Point(313, 266);
            this.txbcidade2.Name = "txbcidade2";
            this.txbcidade2.Size = new System.Drawing.Size(190, 20);
            this.txbcidade2.TabIndex = 128;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(310, 192);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(34, 13);
            this.label26.TabIndex = 134;
            this.label26.Text = "Bairro";
            // 
            // txbbairro2
            // 
            this.txbbairro2.Location = new System.Drawing.Point(313, 208);
            this.txbbairro2.Name = "txbbairro2";
            this.txbbairro2.Size = new System.Drawing.Size(190, 20);
            this.txbbairro2.TabIndex = 127;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(310, 127);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(61, 13);
            this.label28.TabIndex = 133;
            this.label28.Text = "Logradouro";
            // 
            // txblog2
            // 
            this.txblog2.Location = new System.Drawing.Point(313, 143);
            this.txblog2.Name = "txblog2";
            this.txblog2.Size = new System.Drawing.Size(190, 20);
            this.txblog2.TabIndex = 126;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(68, 313);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(94, 13);
            this.label29.TabIndex = 132;
            this.label29.Text = "Inscrição Estadual";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(68, 185);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(27, 13);
            this.label30.TabIndex = 131;
            this.label30.Text = "CPF";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(68, 127);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(40, 13);
            this.label31.TabIndex = 130;
            this.label31.Text = "Código";
            // 
            // txbcod3
            // 
            this.txbcod3.Location = new System.Drawing.Point(71, 143);
            this.txbcod3.Name = "txbcod3";
            this.txbcod3.Size = new System.Drawing.Size(190, 20);
            this.txbcod3.TabIndex = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 124;
            this.label4.Text = "FORNECEDOR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 498);
            this.Controls.Add(this.txbie);
            this.Controls.Add(this.txbcpf);
            this.Controls.Add(this.txbcnpj);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txbtelefone2);
            this.Controls.Add(this.btnfornecedor);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txbcidade2);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txbbairro2);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.txblog2);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.txbcod3);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txbie;
        private System.Windows.Forms.MaskedTextBox txbcpf;
        private System.Windows.Forms.MaskedTextBox txbcnpj;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.MaskedTextBox txbtelefone2;
        private System.Windows.Forms.Button btnfornecedor;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txbcidade2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txbbairro2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txblog2;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txbcod3;
        private System.Windows.Forms.Label label4;
    }
}

