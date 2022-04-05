
namespace ModuloDesktop
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxbEmail = new System.Windows.Forms.TextBox();
            this.TxbSenha = new System.Windows.Forms.TextBox();
            this.LblSenha = new System.Windows.Forms.Label();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.LinkSenha = new System.Windows.Forms.LinkLabel();
            this.CbxSenha = new System.Windows.Forms.CheckBox();
            this.OlhoCortado = new System.Windows.Forms.PictureBox();
            this.OlhoAberto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OlhoCortado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OlhoAberto)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(550, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(47, 46);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(48, 96);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(89, 33);
            this.LblEmail.TabIndex = 8;
            this.LblEmail.Text = "Email";
            // 
            // TxbEmail
            // 
            this.TxbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbEmail.Location = new System.Drawing.Point(143, 93);
            this.TxbEmail.Name = "TxbEmail";
            this.TxbEmail.Size = new System.Drawing.Size(335, 40);
            this.TxbEmail.TabIndex = 2;
            // 
            // TxbSenha
            // 
            this.TxbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbSenha.Location = new System.Drawing.Point(143, 183);
            this.TxbSenha.Name = "TxbSenha";
            this.TxbSenha.Size = new System.Drawing.Size(335, 40);
            this.TxbSenha.TabIndex = 1;
            this.TxbSenha.UseSystemPasswordChar = true;
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenha.Location = new System.Drawing.Point(48, 186);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(98, 33);
            this.LblSenha.TabIndex = 3;
            this.LblSenha.Text = "Senha";
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrar.Location = new System.Drawing.Point(248, 265);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(133, 46);
            this.BtnEntrar.TabIndex = 5;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.UseVisualStyleBackColor = true;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // LinkSenha
            // 
            this.LinkSenha.AutoSize = true;
            this.LinkSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkSenha.LinkColor = System.Drawing.Color.Gray;
            this.LinkSenha.Location = new System.Drawing.Point(232, 335);
            this.LinkSenha.Name = "LinkSenha";
            this.LinkSenha.Size = new System.Drawing.Size(161, 20);
            this.LinkSenha.TabIndex = 6;
            this.LinkSenha.TabStop = true;
            this.LinkSenha.Text = "Esqueci minha senha";
            this.LinkSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSenha_LinkClicked);
            // 
            // CbxSenha
            // 
            this.CbxSenha.AutoSize = true;
            this.CbxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxSenha.Location = new System.Drawing.Point(223, 373);
            this.CbxSenha.Name = "CbxSenha";
            this.CbxSenha.Size = new System.Drawing.Size(182, 24);
            this.CbxSenha.TabIndex = 7;
            this.CbxSenha.Text = "Lembrar minha senha";
            this.CbxSenha.UseVisualStyleBackColor = true;
            // 
            // OlhoCortado
            // 
            this.OlhoCortado.Image = ((System.Drawing.Image)(resources.GetObject("OlhoCortado.Image")));
            this.OlhoCortado.Location = new System.Drawing.Point(484, 186);
            this.OlhoCortado.Name = "OlhoCortado";
            this.OlhoCortado.Size = new System.Drawing.Size(45, 37);
            this.OlhoCortado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OlhoCortado.TabIndex = 11;
            this.OlhoCortado.TabStop = false;
            this.OlhoCortado.Click += new System.EventHandler(this.OlhoCortado_Click);
            // 
            // OlhoAberto
            // 
            this.OlhoAberto.Image = ((System.Drawing.Image)(resources.GetObject("OlhoAberto.Image")));
            this.OlhoAberto.Location = new System.Drawing.Point(484, 186);
            this.OlhoAberto.Name = "OlhoAberto";
            this.OlhoAberto.Size = new System.Drawing.Size(45, 37);
            this.OlhoAberto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OlhoAberto.TabIndex = 10;
            this.OlhoAberto.TabStop = false;
            this.OlhoAberto.Click += new System.EventHandler(this.OlhoAberto_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 484);
            this.ControlBox = false;
            this.Controls.Add(this.OlhoCortado);
            this.Controls.Add(this.OlhoAberto);
            this.Controls.Add(this.CbxSenha);
            this.Controls.Add(this.LinkSenha);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.TxbSenha);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.TxbEmail);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.BtnExit);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.OlhoCortado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OlhoAberto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxbEmail;
        private System.Windows.Forms.TextBox TxbSenha;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.LinkLabel LinkSenha;
        private System.Windows.Forms.CheckBox CbxSenha;
        private System.Windows.Forms.PictureBox OlhoCortado;
        private System.Windows.Forms.PictureBox OlhoAberto;
    }
}