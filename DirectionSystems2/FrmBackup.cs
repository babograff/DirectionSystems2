using System;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using DirectionSystems2.Classes;
using System.IO;

namespace DirectionSystems2
{
    public partial class FrmBackup : Form
    {
        public FrmBackup()
        {
            InitializeComponent();
            LblTitulo.Text = ClassUtilidades.VersaoSistema;
        }

        private void FrmBackup_Load(object sender, EventArgs e)
        {
            TxtBanco.Text = ini.PesquisaIni(Arquivo, "BancoDados");
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu Menu = new FrmMenu();
            Menu.Visible = true;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmBackup Backup = new FrmBackup();
            Backup.Visible = true;
            this.Close();
        }

        private void BtnFexar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            FrmAuditoria Auditoria = new FrmAuditoria();
            Auditoria.Visible = true;
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmImportacao Importacao = new FrmImportacao();
            Importacao.Visible = true;
            this.Close();
        }

        private void BtnMenu_Click_1(object sender, EventArgs e)
        {
            FrmMenu Menu = new FrmMenu();
            Menu.Visible = true;
            this.Close();
        }

        string Arquivo = (@"C:\DirectionSystems2\Configuracao.ini");
        ClassArquivoIni ini = new ClassArquivoIni();
        ClassConexao conexao = new ClassConexao();

        private void BackupDataBase(string databaseName, string destinationPath)
        {
            progressBar1.Style = ProgressBarStyle.Blocks;
            progressBar1.Step = 1;
            progressBar1.Maximum = 10;
            Server myServer = conexao.GetServer();
            Backup backup = new Backup();
            backup.Action = BackupActionType.Database;
            backup.Database = databaseName;
            destinationPath = System.IO.Path.Combine(destinationPath, databaseName + ".bak");
            backup.Devices.Add(new BackupDeviceItem(destinationPath, DeviceType.File));
            backup.Initialize = true;
            backup.Checksum = true;
            backup.ContinueAfterError = true;
            backup.Incremental = false;
            backup.LogTruncation = BackupTruncateLogType.Truncate;
            backup.PercentComplete += new PercentCompleteEventHandler(backup_PercentComplete);
            backup.Complete += new Microsoft.SqlServer.Management.Common.ServerMessageEventHandler(backup_Complete);
            // Perform backup.
            backup.SqlBackup(myServer);
        }

        //The event handlers
        private void backup_Complete(object sender, Microsoft.SqlServer.Management.Common.ServerMessageEventArgs e)
        {
            MessageBox.Show("Ação comcluida");
        }
        private void backup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar1.PerformStep();
        }


        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    TxtCaminho.Text = fbd.SelectedPath;
                }
            }
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            BackupDataBase(TxtBanco.Text, TxtCaminho.Text);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            progressBar2.Style = ProgressBarStyle.Blocks;
            progressBar2.Step = 1;
            progressBar2.Maximum = 10;
            string destinationPath = System.IO.Path.Combine(TxtCaminho.Text,  TxtBanco.Text + ".bak");
            if (File.Exists(destinationPath))
            {
                Restore(TxtBanco.Text, TxtCaminhoRestore.Text);
            }
            else
            {
                MessageBox.Show("Não existe arquivo de backup para restaurar!");
            }
            
        }
        private void Restore(string databaseName, string destinationPath)
        {
            Server myServer = conexao.GetServer();
            Restore restor = new Restore();
            restor.Action = RestoreActionType.Database;
            restor.Database = databaseName;
            destinationPath = System.IO.Path.Combine(destinationPath, databaseName + ".bak");
            restor.Devices.Add(new BackupDeviceItem(destinationPath, DeviceType.File));
            restor.ReplaceDatabase = true;
            restor.PercentComplete += new PercentCompleteEventHandler(Restore_PercentComplete);
            restor.Complete += new Microsoft.SqlServer.Management.Common.ServerMessageEventHandler(backup_Complete);
            restor.SqlRestore(myServer);
        }

        private void Restore_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar2.PerformStep();
        }
    }
}
