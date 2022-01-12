
namespace Usuario
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
            this.btnusuario = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txbsenha = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txbusuario = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txbnome2 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txbcod2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnusuario
            // 
            this.btnusuario.BackColor = System.Drawing.Color.LimeGreen;
            this.btnusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusuario.Location = new System.Drawing.Point(116, 352);
            this.btnusuario.Name = "btnusuario";
            this.btnusuario.Size = new System.Drawing.Size(188, 30);
            this.btnusuario.TabIndex = 114;
            this.btnusuario.Text = "Enviar";
            this.btnusuario.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(112, 288);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 118;
            this.label15.Text = "Senha";
            // 
            // txbsenha
            // 
            this.txbsenha.Location = new System.Drawing.Point(115, 304);
            this.txbsenha.Name = "txbsenha";
            this.txbsenha.Size = new System.Drawing.Size(190, 20);
            this.txbsenha.TabIndex = 113;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(112, 223);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 13);
            this.label20.TabIndex = 117;
            this.label20.Text = "Nome de Usuário";
            // 
            // txbusuario
            // 
            this.txbusuario.Location = new System.Drawing.Point(115, 239);
            this.txbusuario.Name = "txbusuario";
            this.txbusuario.Size = new System.Drawing.Size(190, 20);
            this.txbusuario.TabIndex = 112;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(112, 159);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 116;
            this.label21.Text = "Nome";
            // 
            // txbnome2
            // 
            this.txbnome2.Location = new System.Drawing.Point(115, 175);
            this.txbnome2.Name = "txbnome2";
            this.txbnome2.Size = new System.Drawing.Size(190, 20);
            this.txbnome2.TabIndex = 111;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(112, 101);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 13);
            this.label22.TabIndex = 115;
            this.label22.Text = "Código";
            // 
            // txbcod2
            // 
            this.txbcod2.Location = new System.Drawing.Point(115, 117);
            this.txbcod2.Name = "txbcod2";
            this.txbcod2.Size = new System.Drawing.Size(190, 20);
            this.txbcod2.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 109;
            this.label3.Text = "USUÁRIO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 487);
            this.Controls.Add(this.btnusuario);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txbsenha);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txbusuario);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txbnome2);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txbcod2);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnusuario;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txbsenha;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txbusuario;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txbnome2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txbcod2;
        private System.Windows.Forms.Label label3;
    }
}

