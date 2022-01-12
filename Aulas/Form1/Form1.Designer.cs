
namespace WindowsFormsApp3
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
            this.txbdemissao = new System.Windows.Forms.MaskedTextBox();
            this.txbadimissao = new System.Windows.Forms.MaskedTextBox();
            this.txbtelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.txbtelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.btnfuncionario = new System.Windows.Forms.Button();
            this.btnfornecedor = new System.Windows.Forms.Button();
            this.btnproduto = new System.Windows.Forms.Button();
            this.btnusuario = new System.Windows.Forms.Button();
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
            this.label15 = new System.Windows.Forms.Label();
            this.txbsenha = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txbusuario = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txbnome2 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txbcod2 = new System.Windows.Forms.TextBox();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbie
            // 
            this.txbie.Location = new System.Drawing.Point(685, 695);
            this.txbie.Mask = "00.000.0000-0";
            this.txbie.Name = "txbie";
            this.txbie.Size = new System.Drawing.Size(190, 20);
            this.txbie.TabIndex = 123;
            // 
            // txbcpf
            // 
            this.txbcpf.Location = new System.Drawing.Point(685, 573);
            this.txbcpf.Mask = "000. 000.000-00";
            this.txbcpf.Name = "txbcpf";
            this.txbcpf.Size = new System.Drawing.Size(190, 20);
            this.txbcpf.TabIndex = 122;
            // 
            // txbcnpj
            // 
            this.txbcnpj.Location = new System.Drawing.Point(685, 631);
            this.txbcnpj.Mask = "00. 000.000/0000-00";
            this.txbcnpj.Name = "txbcnpj";
            this.txbcnpj.Size = new System.Drawing.Size(190, 20);
            this.txbcnpj.TabIndex = 121;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(682, 615);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 13);
            this.label23.TabIndex = 120;
            this.label23.Text = "CNPJ";
            // 
            // txbdemissao
            // 
            this.txbdemissao.Location = new System.Drawing.Point(927, 217);
            this.txbdemissao.Mask = "00/00/0000";
            this.txbdemissao.Name = "txbdemissao";
            this.txbdemissao.Size = new System.Drawing.Size(190, 20);
            this.txbdemissao.TabIndex = 119;
            this.txbdemissao.ValidatingType = typeof(System.DateTime);
            // 
            // txbadimissao
            // 
            this.txbadimissao.Location = new System.Drawing.Point(927, 153);
            this.txbadimissao.Mask = "00/00/0000";
            this.txbadimissao.Name = "txbadimissao";
            this.txbadimissao.Size = new System.Drawing.Size(190, 20);
            this.txbadimissao.TabIndex = 118;
            this.txbadimissao.ValidatingType = typeof(System.DateTime);
            // 
            // txbtelefone2
            // 
            this.txbtelefone2.Location = new System.Drawing.Point(927, 695);
            this.txbtelefone2.Mask = "(99) 00000-0000";
            this.txbtelefone2.Name = "txbtelefone2";
            this.txbtelefone2.Size = new System.Drawing.Size(190, 20);
            this.txbtelefone2.TabIndex = 117;
            // 
            // txbtelefone1
            // 
            this.txbtelefone1.Location = new System.Drawing.Point(927, 95);
            this.txbtelefone1.Mask = "(99) 00000-0000";
            this.txbtelefone1.Name = "txbtelefone1";
            this.txbtelefone1.Size = new System.Drawing.Size(190, 20);
            this.txbtelefone1.TabIndex = 116;
            // 
            // btnfuncionario
            // 
            this.btnfuncionario.BackColor = System.Drawing.Color.LimeGreen;
            this.btnfuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfuncionario.Location = new System.Drawing.Point(815, 379);
            this.btnfuncionario.Name = "btnfuncionario";
            this.btnfuncionario.Size = new System.Drawing.Size(188, 30);
            this.btnfuncionario.TabIndex = 99;
            this.btnfuncionario.Text = "Enviar";
            this.btnfuncionario.UseVisualStyleBackColor = false;
            // 
            // btnfornecedor
            // 
            this.btnfornecedor.BackColor = System.Drawing.Color.LimeGreen;
            this.btnfornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfornecedor.Location = new System.Drawing.Point(815, 743);
            this.btnfornecedor.Name = "btnfornecedor";
            this.btnfornecedor.Size = new System.Drawing.Size(188, 30);
            this.btnfornecedor.TabIndex = 103;
            this.btnfornecedor.Text = "Enviar";
            this.btnfornecedor.UseVisualStyleBackColor = false;
            // 
            // btnproduto
            // 
            this.btnproduto.BackColor = System.Drawing.Color.LimeGreen;
            this.btnproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproduto.Location = new System.Drawing.Point(169, 379);
            this.btnproduto.Name = "btnproduto";
            this.btnproduto.Size = new System.Drawing.Size(188, 30);
            this.btnproduto.TabIndex = 98;
            this.btnproduto.Text = "Enviar";
            this.btnproduto.UseVisualStyleBackColor = false;
            // 
            // btnusuario
            // 
            this.btnusuario.BackColor = System.Drawing.Color.LimeGreen;
            this.btnusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusuario.Location = new System.Drawing.Point(169, 743);
            this.btnusuario.Name = "btnusuario";
            this.btnusuario.Size = new System.Drawing.Size(188, 30);
            this.btnusuario.TabIndex = 101;
            this.btnusuario.Text = "Enviar";
            this.btnusuario.UseVisualStyleBackColor = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(924, 679);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 13);
            this.label24.TabIndex = 115;
            this.label24.Text = "Telefone";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(924, 615);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(40, 13);
            this.label25.TabIndex = 114;
            this.label25.Text = "Cidade";
            // 
            // txbcidade2
            // 
            this.txbcidade2.Location = new System.Drawing.Point(927, 631);
            this.txbcidade2.Name = "txbcidade2";
            this.txbcidade2.Size = new System.Drawing.Size(190, 20);
            this.txbcidade2.TabIndex = 96;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(924, 557);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(34, 13);
            this.label26.TabIndex = 113;
            this.label26.Text = "Bairro";
            // 
            // txbbairro2
            // 
            this.txbbairro2.Location = new System.Drawing.Point(927, 573);
            this.txbbairro2.Name = "txbbairro2";
            this.txbbairro2.Size = new System.Drawing.Size(190, 20);
            this.txbbairro2.TabIndex = 94;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(924, 492);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(61, 13);
            this.label28.TabIndex = 112;
            this.label28.Text = "Logradouro";
            // 
            // txblog2
            // 
            this.txblog2.Location = new System.Drawing.Point(927, 508);
            this.txblog2.Name = "txblog2";
            this.txblog2.Size = new System.Drawing.Size(190, 20);
            this.txblog2.TabIndex = 93;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(682, 678);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(94, 13);
            this.label29.TabIndex = 111;
            this.label29.Text = "Inscrição Estadual";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(682, 550);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(27, 13);
            this.label30.TabIndex = 110;
            this.label30.Text = "CPF";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(682, 492);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(40, 13);
            this.label31.TabIndex = 109;
            this.label31.Text = "Código";
            // 
            // txbcod3
            // 
            this.txbcod3.Location = new System.Drawing.Point(685, 508);
            this.txbcod3.Name = "txbcod3";
            this.txbcod3.Size = new System.Drawing.Size(190, 20);
            this.txbcod3.TabIndex = 91;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(165, 679);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 108;
            this.label15.Text = "Senha";
            // 
            // txbsenha
            // 
            this.txbsenha.Location = new System.Drawing.Point(168, 695);
            this.txbsenha.Name = "txbsenha";
            this.txbsenha.Size = new System.Drawing.Size(190, 20);
            this.txbsenha.TabIndex = 89;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(165, 614);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 13);
            this.label20.TabIndex = 107;
            this.label20.Text = "Nome de Usuário";
            // 
            // txbusuario
            // 
            this.txbusuario.Location = new System.Drawing.Point(168, 630);
            this.txbusuario.Name = "txbusuario";
            this.txbusuario.Size = new System.Drawing.Size(190, 20);
            this.txbusuario.TabIndex = 88;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(165, 550);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 106;
            this.label21.Text = "Nome";
            // 
            // txbnome2
            // 
            this.txbnome2.Location = new System.Drawing.Point(168, 566);
            this.txbnome2.Name = "txbnome2";
            this.txbnome2.Size = new System.Drawing.Size(190, 20);
            this.txbnome2.TabIndex = 86;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(165, 492);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 13);
            this.label22.TabIndex = 105;
            this.label22.Text = "Código";
            // 
            // txbcod2
            // 
            this.txbcod2.Location = new System.Drawing.Point(168, 508);
            this.txbcod2.Name = "txbcod2";
            this.txbcod2.Size = new System.Drawing.Size(190, 20);
            this.txbcod2.TabIndex = 84;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(924, 260);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 104;
            this.label16.Text = "Setor";
            // 
            // txbsetor
            // 
            this.txbsetor.Location = new System.Drawing.Point(927, 276);
            this.txbsetor.Name = "txbsetor";
            this.txbsetor.Size = new System.Drawing.Size(190, 20);
            this.txbsetor.TabIndex = 83;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(924, 201);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 102;
            this.label17.Text = "Data Demissão";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(924, 137);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 13);
            this.label18.TabIndex = 100;
            this.label18.Text = "Data Admissão";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(924, 79);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 97;
            this.label19.Text = "Telefone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(682, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 95;
            this.label10.Text = "Cidade";
            // 
            // txbcidade1
            // 
            this.txbcidade1.Location = new System.Drawing.Point(685, 336);
            this.txbcidade1.Name = "txbcidade1";
            this.txbcidade1.Size = new System.Drawing.Size(190, 20);
            this.txbcidade1.TabIndex = 80;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(682, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 92;
            this.label11.Text = "Bairro";
            // 
            // txbbairro1
            // 
            this.txbbairro1.Location = new System.Drawing.Point(685, 276);
            this.txbbairro1.Name = "txbbairro1";
            this.txbbairro1.Size = new System.Drawing.Size(190, 20);
            this.txbbairro1.TabIndex = 79;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(682, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 90;
            this.label12.Text = "Logradouro";
            // 
            // txblog1
            // 
            this.txblog1.Location = new System.Drawing.Point(685, 217);
            this.txblog1.Name = "txblog1";
            this.txblog1.Size = new System.Drawing.Size(190, 20);
            this.txblog1.TabIndex = 77;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(682, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 87;
            this.label13.Text = "Nome";
            // 
            // txbnome1
            // 
            this.txbnome1.Location = new System.Drawing.Point(685, 153);
            this.txbnome1.Name = "txbnome1";
            this.txbnome1.Size = new System.Drawing.Size(190, 20);
            this.txbnome1.TabIndex = 76;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(682, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 85;
            this.label14.Text = "Matrícula";
            // 
            // txbmatricula
            // 
            this.txbmatricula.Location = new System.Drawing.Point(685, 95);
            this.txbmatricula.Name = "txbmatricula";
            this.txbmatricula.Size = new System.Drawing.Size(190, 20);
            this.txbmatricula.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(165, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 82;
            this.label9.Text = "Quantidade Estoque";
            // 
            // txbestoque
            // 
            this.txbestoque.Location = new System.Drawing.Point(168, 336);
            this.txbestoque.Name = "txbestoque";
            this.txbestoque.Size = new System.Drawing.Size(190, 20);
            this.txbestoque.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(164, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 81;
            this.label8.Text = "Preço Venda";
            // 
            // txbvenda
            // 
            this.txbvenda.Location = new System.Drawing.Point(167, 276);
            this.txbvenda.Name = "txbvenda";
            this.txbvenda.Size = new System.Drawing.Size(190, 20);
            this.txbvenda.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 78;
            this.label7.Text = "Preço Compra";
            // 
            // txbcompra
            // 
            this.txbcompra.Location = new System.Drawing.Point(168, 217);
            this.txbcompra.Name = "txbcompra";
            this.txbcompra.Size = new System.Drawing.Size(190, 20);
            this.txbcompra.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "Descrição";
            // 
            // txbdesc
            // 
            this.txbdesc.Location = new System.Drawing.Point(168, 153);
            this.txbdesc.Name = "txbdesc";
            this.txbdesc.Size = new System.Drawing.Size(190, 20);
            this.txbdesc.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "Código";
            // 
            // txbcod1
            // 
            this.txbcod1.Location = new System.Drawing.Point(168, 95);
            this.txbcod1.Name = "txbcod1";
            this.txbcod1.Size = new System.Drawing.Size(190, 20);
            this.txbcod1.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(681, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 69;
            this.label4.Text = "FORNECEDOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 67;
            this.label3.Text = "USUÁRIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(681, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 66;
            this.label2.Text = "FUNCIONÁRIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 64;
            this.label1.Text = "PRODUTO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 813);
            this.Controls.Add(this.txbie);
            this.Controls.Add(this.txbcpf);
            this.Controls.Add(this.txbcnpj);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txbdemissao);
            this.Controls.Add(this.txbadimissao);
            this.Controls.Add(this.txbtelefone2);
            this.Controls.Add(this.txbtelefone1);
            this.Controls.Add(this.btnfuncionario);
            this.Controls.Add(this.btnfornecedor);
            this.Controls.Add(this.btnproduto);
            this.Controls.Add(this.btnusuario);
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
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txbsenha);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txbusuario);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txbnome2);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txbcod2);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.MaskedTextBox txbdemissao;
        private System.Windows.Forms.MaskedTextBox txbadimissao;
        private System.Windows.Forms.MaskedTextBox txbtelefone2;
        private System.Windows.Forms.MaskedTextBox txbtelefone1;
        private System.Windows.Forms.Button btnfuncionario;
        private System.Windows.Forms.Button btnfornecedor;
        private System.Windows.Forms.Button btnproduto;
        private System.Windows.Forms.Button btnusuario;
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
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txbsenha;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txbusuario;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txbnome2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txbcod2;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

