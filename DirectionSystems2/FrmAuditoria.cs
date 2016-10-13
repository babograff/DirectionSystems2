using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DirectionSystems2.Classes;
using System.Data.SqlClient;

namespace DirectionSystems2
{
    public partial class FrmAuditoria : Form
    {
        public FrmAuditoria()
        {
            InitializeComponent();
            LblTitulo.Text = ClassUtilidades.VersaoSistema;
            CboTabela.SelectedIndex = 1;
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu Menu = new FrmMenu();
            Menu.Visible = true;
            this.Close();
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            FrmAuditoria Auditoria = new FrmAuditoria();
            Auditoria.Visible = true;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmImportacao Importacao = new FrmImportacao();
            Importacao.Visible = true;
            this.Close();
        }

        private void FrmAuditoria_Load(object sender, EventArgs e)
        {

        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnFexar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        ClassConexao Conexao = new ClassConexao();
        private void Pesquisar()
        {
            SqlConnection conn = Conexao.AbreConexao();
            SqlCommand cmd = new SqlCommand("spAuditoria", conn);
            cmd.Parameters.AddWithValue("@Usuario", TxtUsuario.Text);
            cmd.Parameters.AddWithValue("@DataInicial", TxtDataInicial.Value.ToShortTimeString());
            cmd.Parameters.AddWithValue("@DataFinal", TxtDataFinal.Value.ToShortTimeString());
            cmd.Parameters.AddWithValue("@Tabela", CboTabela.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Contem", TxtContem.Text);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                GridAuditoria.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                Conexao.FechaConexao(conn);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmBackup Backup = new FrmBackup();
            Backup.Visible = true;
            this.Close();
        }
    }
}
