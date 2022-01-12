
namespace Produto
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
            this.btnproduto = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txbestoque = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbvenda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbcompra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbdesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbcod1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnproduto
            // 
            this.btnproduto.BackColor = System.Drawing.Color.LimeGreen;
            this.btnproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproduto.Location = new System.Drawing.Point(93, 407);
            this.btnproduto.Name = "btnproduto";
            this.btnproduto.Size = new System.Drawing.Size(188, 30);
            this.btnproduto.TabIndex = 110;
            this.btnproduto.Text = "Enviar";
            this.btnproduto.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 109;
            this.label9.Text = "Quantidade Estoque";
            // 
            // txbestoque
            // 
            this.txbestoque.Location = new System.Drawing.Point(92, 364);
            this.txbestoque.Name = "txbestoque";
            this.txbestoque.Size = new System.Drawing.Size(190, 20);
            this.txbestoque.TabIndex = 105;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 108;
            this.label8.Text = "Preço Venda";
            // 
            // txbvenda
            // 
            this.txbvenda.Location = new System.Drawing.Point(91, 304);
            this.txbvenda.Name = "txbvenda";
            this.txbvenda.Size = new System.Drawing.Size(190, 20);
            this.txbvenda.TabIndex = 103;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 107;
            this.label7.Text = "Preço Compra";
            // 
            // txbcompra
            // 
            this.txbcompra.Location = new System.Drawing.Point(92, 245);
            this.txbcompra.Name = "txbcompra";
            this.txbcompra.Size = new System.Drawing.Size(190, 20);
            this.txbcompra.TabIndex = 102;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 106;
            this.label6.Text = "Descrição";
            // 
            // txbdesc
            // 
            this.txbdesc.Location = new System.Drawing.Point(92, 181);
            this.txbdesc.Name = "txbdesc";
            this.txbdesc.Size = new System.Drawing.Size(190, 20);
            this.txbdesc.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 104;
            this.label5.Text = "Código";
            // 
            // txbcod1
            // 
            this.txbcod1.Location = new System.Drawing.Point(92, 123);
            this.txbcod1.Name = "txbcod1";
            this.txbcod1.Size = new System.Drawing.Size(190, 20);
            this.txbcod1.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 99;
            this.label1.Text = "PRODUTO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 512);
            this.Controls.Add(this.btnproduto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbestoque);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbvenda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbcompra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbdesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbcod1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnproduto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbestoque;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbvenda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbcompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbdesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbcod1;
        private System.Windows.Forms.Label label1;
    }
}

