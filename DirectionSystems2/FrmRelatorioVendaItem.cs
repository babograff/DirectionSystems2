using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using DirectionSystems2.Classes;

namespace DirectionSystems2
{
    public partial class FrmRelatorioVendaItem : Form
    {
        public FrmRelatorioVendaItem()
        {
            InitializeComponent();
            LblTitulo.Text = ClassUtilidades.VersaoSistema;
        }

        ClassConexao Conexao = new ClassConexao();
        private void FrmRelatorioVendaItem_Load(object sender, EventArgs e)
        {


        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu Menu = new FrmMenu();
            Menu.Visible = true;
            this.Close();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            ReportParameter p1 = new ReportParameter("DataInicial", TxtDataInicial.Value.ToShortDateString());
            ReportParameter p2 = new ReportParameter("DataFinal", TxtDataFinal.Value.ToShortDateString());

            SqlConnection conn = Conexao.AbreConexao();
            SqlCommand cmd = new SqlCommand("spRelatorioItemVenda", conn);
            cmd.Parameters.AddWithValue("@DataInicial", TxtDataInicial.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@DataFinal", TxtDataFinal.Value.ToShortDateString());
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Open();
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                var source = new ReportDataSource("DataSet1", data);
                this.reportViewer1.LocalReport.DataSources.Add(source);
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1, p2 });
                this.reportViewer1.RefreshReport();
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

        private void BtnFuncionario_Click(object sender, EventArgs e)
        {
            FrmRelatorioCurvaABC CurvaABC = new FrmRelatorioCurvaABC();
            CurvaABC.Visible = true;
            this.Close();
        }

        private void BtnProduto_Click(object sender, EventArgs e)
        {
            FrmRelatorioVendaItem RelatorioVendaItem = new FrmRelatorioVendaItem();
            RelatorioVendaItem.Visible = true;
            this.Close();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnFexar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnAjuda_Click(object sender, EventArgs e)
        {
            FrmRelatorioVendaItemAjuda RelatorioVendaItemAjuda = new FrmRelatorioVendaItemAjuda();
            RelatorioVendaItemAjuda.Visible = true;
        }
    }
}
