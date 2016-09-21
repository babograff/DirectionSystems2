using System;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using DirectionSystems2.Classes;

namespace DirectionSystems2
{
    public partial class FrmBoasVindas : Form
    {
        public FrmBoasVindas()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Visible = false;
            string ArquivoConfiguração = "C:\\DirectionSystems2\\Configuracao.ini";
            if (System.IO.File.Exists(@ArquivoConfiguração))
            {
                try
                {
                    ClassArquivoIni ini = new ClassArquivoIni();
                    var ping = new Ping();
                    var reply = ping.Send(ini.PesquisaIni(@ArquivoConfiguração, "Servidor"));
                    if (reply.Status == IPStatus.Success)
                    {
                        FrmLogin Login = new FrmLogin();
                        Login.Visible = true;
                    }
                    else {

                        FrmConfiguracaoBanco ConfiguracaoBanco = new FrmConfiguracaoBanco();
                        ConfiguracaoBanco.Visible = true;
                    }
                }
                catch
                {
                    FrmConfiguracaoBanco ConfiguracaoBanco = new FrmConfiguracaoBanco();
                    ConfiguracaoBanco.Visible = true;
                }
            }
            else
            {
                FrmConfiguracaoBanco ConfiguracaoBanco = new FrmConfiguracaoBanco();
                ConfiguracaoBanco.Visible = true;
            }
        }

        private void FrmBoasVindas_Load(object sender, EventArgs e)
        {

        }
    }
}
