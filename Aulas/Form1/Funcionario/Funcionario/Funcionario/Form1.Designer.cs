
namespace Funcionario
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
            this.txbdemissao = new System.Windows.Forms.MaskedTextBox();
            this.txbadimissao = new System.Windows.Forms.MaskedTextBox();
            this.txbtelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.btnfuncionario = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txbsetor = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbcidade1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbbairro1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txblog1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbnome1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txbmatricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbdemissao
            // 
            this.txbdemissao.Location = new System.Drawing.Point(338, 265);
            this.txbdemissao.Mask = "00/00/0000";
            this.txbdemissao.Name = "txbdemissao";
            this.txbdemissao.Size = new System.Drawing.Size(190, 20);
            this.txbdemissao.TabIndex = 139;
            this.txbdemissao.ValidatingType = typeof(System.DateTime);
            // 
            // txbadimissao
            // 
            this.txbadimissao.Location = new System.Drawing.Point(338, 201);
            this.txbadimissao.Mask = "00/00/0000";
            this.txbadimissao.Name = "txbadimissao";
            this.txbadimissao.Size = new System.Drawing.Size(190, 20);
            this.txbadimissao.TabIndex = 138;
            this.txbadimissao.ValidatingType = typeof(System.DateTime);
            // 
            // txbtelefone1
            // 
            this.txbtelefone1.Location = new System.Drawing.Point(338, 143);
            this.txbtelefone1.Mask = "(99) 00000-0000";
            this.txbtelefone1.Name = "txbtelefone1";
            this.txbtelefone1.Size = new System.Drawing.Size(190, 20);
            this.txbtelefone1.TabIndex = 137;
            // 
            // btnfuncionario
            // 
            this.btnfuncionario.BackColor = System.Drawing.Color.LimeGreen;
            this.btnfuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfuncionario.Location = new System.Drawing.Point(226, 427);
            this.btnfuncionario.Name = "btnfuncionario";
            this.btnfuncionario.Size = new System.Drawing.Size(188, 30);
            this.btnfuncionario.TabIndex = 133;
            this.btnfuncionario.Text = "Enviar";
            this.btnfuncionario.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(335, 308);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 136;
            this.label16.Text = "Setor";
            // 
            // txbsetor
            // 
            this.txbsetor.Location = new System.Drawing.Point(338, 324);
            this.txbsetor.Name = "txbsetor";
            this.txbsetor.Size = new System.Drawing.Size(190, 20);
            this.txbsetor.TabIndex = 126;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(335, 249);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 135;
            this.label17.Text = "Data Demissão";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(335, 185);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 13);
            this.label18.TabIndex = 134;
            this.label18.Text = "Data Admissão";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(335, 127);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 132;
            this.label19.Text = "Telefone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(93, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 131;
            this.label10.Text = "Cidade";
            // 
            // txbcidade1
            // 
            this.txbcidade1.Location = new System.Drawing.Point(96, 384);
            this.txbcidade1.Name = "txbcidade1";
            this.txbcidade1.Size = new System.Drawing.Size(190, 20);
            this.txbcidade1.TabIndex = 125;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(93, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 130;
            this.label11.Text = "Bairro";
            // 
            // txbbairro1
            // 
            this.txbbairro1.Location = new System.Drawing.Point(96, 324);
            this.txbbairro1.Name = "txbbairro1";
            this.txbbairro1.Size = new System.Drawing.Size(190, 20);
            this.txbbairro1.TabIndex = 124;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(93, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 129;
            this.label12.Text = "Logradouro";
            // 
            // txblog1
            // 
            this.txblog1.Location = new System.Drawing.Point(96, 265);
            this.txblog1.Name = "txblog1";
            this.txblog1.Size = new System.Drawing.Size(190, 20);
            this.txblog1.TabIndex = 123;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(93, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 128;
            this.label13.Text = "Nome";
            // 
            // txbnome1
            // 
            this.txbnome1.Location = new System.Drawing.Point(96, 201);
            this.txbnome1.Name = "txbnome1";
            this.txbnome1.Size = new System.Drawing.Size(190, 20);
            this.txbnome1.TabIndex = 122;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(93, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 127;
            this.label14.Text = "Matrícula";
            // 
            // txbmatricula
            // 
            this.txbmatricula.Location = new System.Drawing.Point(96, 143);
            this.txbmatricula.Name = "txbmatricula";
            this.txbmatricula.Size = new System.Drawing.Size(190, 20);
            this.txbmatricula.TabIndex = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 120;
            this.label2.Text = "FUNCIONÁRIO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 587);
            this.Controls.Add(this.txbdemissao);
            this.Controls.Add(this.txbadimissao);
            this.Controls.Add(this.txbtelefone1);
            this.Controls.Add(this.btnfuncionario);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txbsetor);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbcidade1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbbairro1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txblog1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txbnome1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txbmatricula);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txbdemissao;
        private System.Windows.Forms.MaskedTextBox txbadimissao;
        private System.Windows.Forms.MaskedTextBox txbtelefone1;
        private System.Windows.Forms.Button btnfuncionario;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txbsetor;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbcidade1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbbairro1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txblog1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbnome1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txbmatricula;
        private System.Windows.Forms.Label label2;
    }
}

