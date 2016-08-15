using DirectionSystems2.Properties;
using System;
using System.Windows.Forms;
using DirectionSystems2.Classes;

namespace DirectionSystems2
{
    public partial class FrmConfiguracaoBanco : Form
    {
        public FrmConfiguracaoBanco()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string Conteudo = "Servidor=" + TxtIP.Text + "|BancoDados=" + TxtBanco.Text + "|Instancia=" + TxtInstancia.Text + "|Porta=" + TxtPorta.Text + "|Usuario=sa|Senha=s4udasta";
            string Arquivo = (@"C:\DirectionSystems2\Configuracao.ini");
            ClassCriptoArq ArquivoCripto = new ClassCriptoArq();
            if(ArquivoCripto.EncryptFile(Conteudo, Arquivo)) 
            {
                MessageBox.Show("Arquivo de configuração salvo com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Visible = false;
                FrmBoasVindas BoasVindas = new FrmBoasVindas();
                BoasVindas.Visible = true;
            }
            else
            {
                MessageBox.Show("Erro ao salvar arquivo de configuração!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.BotaoSalvarMaiorAtivo;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.BotaoSalvarMaior;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.BotaoCancelarLoginAtivo;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.BotaoCancelarLogin;
        }

        private void FrmConfiguracaoBanco_Load(object sender, EventArgs e)
        {
            string Arquivo = (@"C:\DirectionSystems2\Configuracao.ini");
            if (System.IO.File.Exists(@Arquivo))
            {
                ClassArquivoIni ini = new ClassArquivoIni();
                TxtIP.Text = ini.PesquisaIni(Arquivo, "Servidor");
                TxtBanco.Text = ini.PesquisaIni(Arquivo, "BancoDados");
                TxtInstancia.Text = ini.PesquisaIni(Arquivo, "Instancia");
                TxtPorta.Text = ini.PesquisaIni(Arquivo, "Porta");
            }
        }
    }
}
