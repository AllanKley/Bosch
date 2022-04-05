using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ModuloDesktop
{
    public partial class SenhaRandomica : Form
    {
        public static string Senha;

        public SenhaRandomica()
        {
            InitializeComponent();
            Random rnd = new Random(); // objeto para gerar numeros randomicos

            List<string> Alpha = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
                "a", "b", "c", "d", "e","f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

            for(int i= 0; i< 6; i++) // gerando 6 numero aleatorios pelo for
            {
                int Decider = rnd.Next(); // gerando qualquer valor
                Decider = Decider % 2; 

                if (Decider == 1) // se o for 1 gera um numero
                {
                    Senha = Senha + rnd.Next(0, 10); // de 0 a 9 
                }
                else
                {
                    Senha = Senha + Alpha[rnd.Next(0, Alpha.Count)]; // se for 0 o resto puxa uma letra do alpha
                }
            }

            TxbSenha.Text = Senha;
            TxbSenha.Enabled = false;
          
        }

        private void label1_Click(object sender, EventArgs e)
        {       
        }

        private void BtnCopia_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Senha);// copiando a senha gerada par ao crtl c v

            this.Hide();
            LoginEsqueceuSenha LoginSenha = new LoginEsqueceuSenha();
            LoginSenha.Show();
  
        }
    }
}
