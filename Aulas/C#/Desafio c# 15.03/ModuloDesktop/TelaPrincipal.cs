using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Globalization;


namespace ModuloDesktop
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            try
            {
                string ServerConnection = "Server= JVLPC0553; Database = ModuloDesktop; Trusted_Connection = True;"; // caminho de conexão com o DB
                SqlConnection conexao = new SqlConnection(ServerConnection);  // instancia de conexão 
                SqlCommand comando;





                comando = new SqlCommand($"SELECT Foto from Usuarios where idUsuario = {EmailValidation.idUsuario}", conexao);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataSet ds = new DataSet();

                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Foto"]);
                    img_Perf.Image = new Bitmap(ms);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Usuário sem foto de perfil | {0}", ex);
                img_Perf.Image = Image.FromFile(@"S:\COM\Human_Resources\01.Engineering_Tech_School\02.Internal\10 - Aprendizes\5 - Desenvolvimento de Sistemas\1 - Alunos\Allan Kley\Desafio c# 15.03\DataFiles\Icones\SemFoto.png");
            }


        }

        

        private void BtnConvidados_Click(object sender, EventArgs e)
        {
            
            MenuConvidados convidados = new MenuConvidados();
            convidados.Show();
            this.Hide();
        }

        private void BtnJogos_Click(object sender, EventArgs e)
        {
            FormJogos jogos = new FormJogos();
            jogos.Show();
            this.Hide();
        }

        private void img_Perf_Click(object sender, EventArgs e)
        {
            TelaPerfil perfil = new TelaPerfil();
            perfil.Show();
           
        }
    }
}


