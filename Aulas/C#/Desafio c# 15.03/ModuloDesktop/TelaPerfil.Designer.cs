
namespace ModuloDesktop
{
    partial class TelaPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPerfil));
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PicturePerfil = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxbNascimento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.TxbTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxbCor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxbApelido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxbSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OlhoCortado = new System.Windows.Forms.PictureBox();
            this.OlhoAberto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePerfil)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OlhoCortado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OlhoAberto)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(228, 432);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(174, 33);
            this.BtnSalvar.TabIndex = 13;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(486, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Foto";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PicturePerfil
            // 
            this.PicturePerfil.Image = ((System.Drawing.Image)(resources.GetObject("PicturePerfil.Image")));
            this.PicturePerfil.InitialImage = ((System.Drawing.Image)(resources.GetObject("PicturePerfil.InitialImage")));
            this.PicturePerfil.Location = new System.Drawing.Point(486, 47);
            this.PicturePerfil.Name = "PicturePerfil";
            this.PicturePerfil.Size = new System.Drawing.Size(118, 118);
            this.PicturePerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicturePerfil.TabIndex = 11;
            this.PicturePerfil.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxbNascimento);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxbTime);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxbCor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxbApelido);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(20, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 232);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // TxbNascimento
            // 
            this.TxbNascimento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbNascimento.Location = new System.Drawing.Point(179, 186);
            this.TxbNascimento.Name = "TxbNascimento";
            this.TxbNascimento.Size = new System.Drawing.Size(233, 29);
            this.TxbNascimento.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nascimento:";
            // 
            // TxbTime
            // 
            this.TxbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbTime.Location = new System.Drawing.Point(179, 130);
            this.TxbTime.Name = "TxbTime";
            this.TxbTime.Size = new System.Drawing.Size(233, 29);
            this.TxbTime.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Time Favorito:";
            // 
            // TxbCor
            // 
            this.TxbCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbCor.Location = new System.Drawing.Point(179, 76);
            this.TxbCor.Name = "TxbCor";
            this.TxbCor.Size = new System.Drawing.Size(233, 29);
            this.TxbCor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cor Favorita:";
            // 
            // TxbApelido
            // 
            this.TxbApelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbApelido.Location = new System.Drawing.Point(179, 19);
            this.TxbApelido.Name = "TxbApelido";
            this.TxbApelido.Size = new System.Drawing.Size(233, 29);
            this.TxbApelido.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Apelido:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OlhoCortado);
            this.groupBox1.Controls.Add(this.OlhoAberto);
            this.groupBox1.Controls.Add(this.TxbSenha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxbEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 126);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // TxbSenha
            // 
            this.TxbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbSenha.Location = new System.Drawing.Point(179, 79);
            this.TxbSenha.Name = "TxbSenha";
            this.TxbSenha.Size = new System.Drawing.Size(233, 29);
            this.TxbSenha.TabIndex = 3;
            this.TxbSenha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha:";
            // 
            // TxbEmail
            // 
            this.TxbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbEmail.Location = new System.Drawing.Point(179, 19);
            this.TxbEmail.Name = "TxbEmail";
            this.TxbEmail.Size = new System.Drawing.Size(233, 29);
            this.TxbEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // OlhoCortado
            // 
            this.OlhoCortado.Image = ((System.Drawing.Image)(resources.GetObject("OlhoCortado.Image")));
            this.OlhoCortado.Location = new System.Drawing.Point(132, 79);
            this.OlhoCortado.Name = "OlhoCortado";
            this.OlhoCortado.Size = new System.Drawing.Size(31, 29);
            this.OlhoCortado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OlhoCortado.TabIndex = 15;
            this.OlhoCortado.TabStop = false;
            this.OlhoCortado.Click += new System.EventHandler(this.OlhoCortado_Click);
            // 
            // OlhoAberto
            // 
            this.OlhoAberto.Image = ((System.Drawing.Image)(resources.GetObject("OlhoAberto.Image")));
            this.OlhoAberto.Location = new System.Drawing.Point(132, 79);
            this.OlhoAberto.Name = "OlhoAberto";
            this.OlhoAberto.Size = new System.Drawing.Size(31, 29);
            this.OlhoAberto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OlhoAberto.TabIndex = 14;
            this.OlhoAberto.TabStop = false;
            this.OlhoAberto.Click += new System.EventHandler(this.OlhoAberto_Click);
            // 
            // TelaPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 547);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PicturePerfil);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TelaPerfil";
            this.Text = "TelaPerfil";
            ((System.ComponentModel.ISupportInitialize)(this.PicturePerfil)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OlhoCortado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OlhoAberto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox PicturePerfil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker TxbNascimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxbTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxbCor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxbApelido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxbSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox OlhoCortado;
        private System.Windows.Forms.PictureBox OlhoAberto;
    }
}