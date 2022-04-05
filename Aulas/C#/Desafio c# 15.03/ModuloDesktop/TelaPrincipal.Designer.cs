
namespace ModuloDesktop
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.BtnConvidados = new System.Windows.Forms.Button();
            this.BtnJogos = new System.Windows.Forms.Button();
            this.BtnRanking = new System.Windows.Forms.Button();
            this.BtnNotificações = new System.Windows.Forms.Button();
            this.BtnConfigurações = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.img_Perf = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Perf)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnConvidados
            // 
            resources.ApplyResources(this.BtnConvidados, "BtnConvidados");
            this.BtnConvidados.Name = "BtnConvidados";
            this.BtnConvidados.UseVisualStyleBackColor = true;
            this.BtnConvidados.Click += new System.EventHandler(this.BtnConvidados_Click);
            // 
            // BtnJogos
            // 
            resources.ApplyResources(this.BtnJogos, "BtnJogos");
            this.BtnJogos.Name = "BtnJogos";
            this.BtnJogos.UseVisualStyleBackColor = true;
            this.BtnJogos.Click += new System.EventHandler(this.BtnJogos_Click);
            // 
            // BtnRanking
            // 
            resources.ApplyResources(this.BtnRanking, "BtnRanking");
            this.BtnRanking.Name = "BtnRanking";
            this.BtnRanking.UseVisualStyleBackColor = true;
            // 
            // BtnNotificações
            // 
            resources.ApplyResources(this.BtnNotificações, "BtnNotificações");
            this.BtnNotificações.Name = "BtnNotificações";
            this.BtnNotificações.UseVisualStyleBackColor = true;
            // 
            // BtnConfigurações
            // 
            resources.ApplyResources(this.BtnConfigurações, "BtnConfigurações");
            this.BtnConfigurações.Name = "BtnConfigurações";
            this.BtnConfigurações.UseVisualStyleBackColor = true;
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
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // img_Perf
            // 
            resources.ApplyResources(this.img_Perf, "img_Perf");
            this.img_Perf.Name = "img_Perf";
            this.img_Perf.TabStop = false;
            this.img_Perf.Click += new System.EventHandler(this.img_Perf_Click);
            // 
            // TelaPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "TelaPrincipal";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_Perf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnConvidados;
        private System.Windows.Forms.Button BtnJogos;
        private System.Windows.Forms.Button BtnRanking;
        private System.Windows.Forms.Button BtnNotificações;
        private System.Windows.Forms.Button BtnConfigurações;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox img_Perf;
    }
}