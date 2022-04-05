
namespace ModuloDesktop
{
    partial class SenhaRandomica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxbSenha = new System.Windows.Forms.TextBox();
            this.BtnCopia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nova Senha:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxbSenha
            // 
            this.TxbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbSenha.Location = new System.Drawing.Point(181, 132);
            this.TxbSenha.Name = "TxbSenha";
            this.TxbSenha.Size = new System.Drawing.Size(298, 31);
            this.TxbSenha.TabIndex = 1;
            // 
            // BtnCopia
            // 
            this.BtnCopia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCopia.Location = new System.Drawing.Point(519, 127);
            this.BtnCopia.Name = "BtnCopia";
            this.BtnCopia.Size = new System.Drawing.Size(79, 42);
            this.BtnCopia.TabIndex = 3;
            this.BtnCopia.Text = "Copiar";
            this.BtnCopia.UseVisualStyleBackColor = true;
            this.BtnCopia.Click += new System.EventHandler(this.BtnCopia_Click);
            // 
            // SenhaRandomica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 360);
            this.Controls.Add(this.BtnCopia);
            this.Controls.Add(this.TxbSenha);
            this.Controls.Add(this.label1);
            this.Name = "SenhaRandomica";
            this.Text = "SenhaRandomica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbSenha;
        private System.Windows.Forms.Button BtnCopia;
    }
}