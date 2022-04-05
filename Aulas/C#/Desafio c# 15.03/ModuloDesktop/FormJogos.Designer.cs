
namespace ModuloDesktop
{
    partial class FormJogos
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
            this.tb_Jogos = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placar1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placar2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.img_Perf = new System.Windows.Forms.PictureBox();
            this.BtnConfigurações = new System.Windows.Forms.Button();
            this.BtnNotificações = new System.Windows.Forms.Button();
            this.BtnRanking = new System.Windows.Forms.Button();
            this.BtnJogos = new System.Windows.Forms.Button();
            this.BtnConvidados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Jogos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Perf)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Jogos
            // 
            this.tb_Jogos.AllowUserToOrderColumns = true;
            this.tb_Jogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_Jogos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Time1,
            this.Placar1,
            this.X,
            this.Placar2,
            this.Time2});
            this.tb_Jogos.Location = new System.Drawing.Point(12, 66);
            this.tb_Jogos.Name = "tb_Jogos";
            this.tb_Jogos.Size = new System.Drawing.Size(776, 372);
            this.tb_Jogos.TabIndex = 0;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Time1
            // 
            this.Time1.DataPropertyName = "Selecao1";
            this.Time1.HeaderText = "Time1";
            this.Time1.Name = "Time1";
            this.Time1.ReadOnly = true;
            // 
            // Placar1
            // 
            this.Placar1.DataPropertyName = "Placar1";
            this.Placar1.HeaderText = "Placar1";
            this.Placar1.Name = "Placar1";
            this.Placar1.ReadOnly = true;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            // 
            // Placar2
            // 
            this.Placar2.DataPropertyName = "Placar2";
            this.Placar2.HeaderText = "Placar2";
            this.Placar2.Name = "Placar2";
            this.Placar2.ReadOnly = true;
            // 
            // Time2
            // 
            this.Time2.DataPropertyName = "Selecao2";
            this.Time2.HeaderText = "Time2";
            this.Time2.Name = "Time2";
            this.Time2.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.img_Perf);
            this.panel1.Controls.Add(this.BtnConfigurações);
            this.panel1.Controls.Add(this.BtnNotificações);
            this.panel1.Controls.Add(this.BtnRanking);
            this.panel1.Controls.Add(this.BtnJogos);
            this.panel1.Controls.Add(this.BtnConvidados);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 43);
            this.panel1.TabIndex = 7;
            // 
            // img_Perf
            // 
            this.img_Perf.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.img_Perf.Location = new System.Drawing.Point(730, 3);
            this.img_Perf.Name = "img_Perf";
            this.img_Perf.Size = new System.Drawing.Size(41, 35);
            this.img_Perf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Perf.TabIndex = 7;
            this.img_Perf.TabStop = false;
            this.img_Perf.Click += new System.EventHandler(this.img_Perf_Click);
            // 
            // BtnConfigurações
            // 
            this.BtnConfigurações.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BtnConfigurações.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnConfigurações.Location = new System.Drawing.Point(575, 3);
            this.BtnConfigurações.Name = "BtnConfigurações";
            this.BtnConfigurações.Size = new System.Drawing.Size(137, 35);
            this.BtnConfigurações.TabIndex = 4;
            this.BtnConfigurações.Text = "Configurações";
            this.BtnConfigurações.UseVisualStyleBackColor = true;
            // 
            // BtnNotificações
            // 
            this.BtnNotificações.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BtnNotificações.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnNotificações.Location = new System.Drawing.Point(432, 3);
            this.BtnNotificações.Name = "BtnNotificações";
            this.BtnNotificações.Size = new System.Drawing.Size(137, 35);
            this.BtnNotificações.TabIndex = 3;
            this.BtnNotificações.Text = "Notificações";
            this.BtnNotificações.UseVisualStyleBackColor = true;
            // 
            // BtnRanking
            // 
            this.BtnRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BtnRanking.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnRanking.Location = new System.Drawing.Point(289, 3);
            this.BtnRanking.Name = "BtnRanking";
            this.BtnRanking.Size = new System.Drawing.Size(137, 35);
            this.BtnRanking.TabIndex = 2;
            this.BtnRanking.Text = "Ranking";
            this.BtnRanking.UseVisualStyleBackColor = true;
            // 
            // BtnJogos
            // 
            this.BtnJogos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BtnJogos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnJogos.Location = new System.Drawing.Point(146, 3);
            this.BtnJogos.Name = "BtnJogos";
            this.BtnJogos.Size = new System.Drawing.Size(137, 35);
            this.BtnJogos.TabIndex = 1;
            this.BtnJogos.Text = "Jogos";
            this.BtnJogos.UseVisualStyleBackColor = true;
            // 
            // BtnConvidados
            // 
            this.BtnConvidados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BtnConvidados.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnConvidados.Location = new System.Drawing.Point(3, 3);
            this.BtnConvidados.Name = "BtnConvidados";
            this.BtnConvidados.Size = new System.Drawing.Size(137, 35);
            this.BtnConvidados.TabIndex = 0;
            this.BtnConvidados.Text = "Convidados";
            this.BtnConvidados.UseVisualStyleBackColor = true;
            this.BtnConvidados.Click += new System.EventHandler(this.BtnConvidados_Click_1);
            // 
            // FormJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_Jogos);
            this.Name = "FormJogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormJogos";
            this.Load += new System.EventHandler(this.FormJogos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_Jogos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_Perf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tb_Jogos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placar2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox img_Perf;
        private System.Windows.Forms.Button BtnConfigurações;
        private System.Windows.Forms.Button BtnNotificações;
        private System.Windows.Forms.Button BtnRanking;
        private System.Windows.Forms.Button BtnJogos;
        private System.Windows.Forms.Button BtnConvidados;
    }
}