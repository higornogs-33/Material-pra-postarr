using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Estruturas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            string usuario = "EtecUsu";
            string senha = "Etec_Usu";

            if (usuario == txtUsuario.Text & senha == txtSenha.Text)
            {
                frmCadastro cadastro = new frmCadastro();
                cadastro.FormBorderStyle = FormBorderStyle.None;
                cadastro.Bounds = Screen.PrimaryScreen.Bounds;
                cadastro.TopMost = true;
                cadastro.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!!", "Verificação",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
                txtUsuario.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int n1 = 0;
            lsbMostra.Items.Clear();
            double cubico = 0;

            while (cubico < 100)
            {
                cubico = n1 * n1 * n1;
                n1++;
                lsbMostra.Items.Add(cubico.ToString());
            }

        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int n2 = 0;
            lsbMostra.Items.Clear();

            do
            {
                lsbMostra.Items.Add((n2 * 2).ToString());
                n2++;
            }
            while (n2 < 51);
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int n3 = 0;
            lsbMostra.Items.Clear();

            for (n3 = 90; n3 >= 3; n3 -= 3)
            {
                lsbMostra.Items.Add(n3.ToString());
            }
        }

        private void btnForEach_Click(object sender, EventArgs e)
        {
            // Array ou vetor é uma estrutura de dados que armazena
            // valores que podem ser acessados por uma posição
            // deuses[0] = "Maça", deuses[1] = "Mamão",.....
            string[] cores = ["Amarelo", "Azul", "Branco", "Vermelho", "Verde"];

            lsbMostra.Items.Clear();
            // lsbMostra.Items.Add(cores[0]);
            // lsbMostra.Items.Add(cores[1]);

            foreach (string lista in cores)
            {
                lsbMostra.Items.Add(lista);
            }
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            int n4 = 0;
            lsbMostra.Items.Clear();
            double soma = 0;

            while (n4 <= 20) 
            {
                soma = soma + n4;
                n4++;
                if (n4 == -400)  
                {
                    break;
                }
                lsbMostra.Items.Add(soma.ToString());
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            lsbMostra.Items.Clear();

            double resultado = 0;

            for (int n5 = 0; n5 <= 10; n5++)
            {
                if (n5 == 5)
                {
                    continue;
                }

                resultado = Math.Sqrt(n5);
                lsbMostra.Items.Add(resultado);
            }
        }
    }
}

