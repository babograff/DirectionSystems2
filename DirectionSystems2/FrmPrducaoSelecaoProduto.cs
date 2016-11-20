using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DirectionSystems2.Classes;
using System.Data.SqlClient;
using System.Linq;


namespace DirectionSystems2
{
    public partial class FrmPrducaoSelecaoProduto : Form
    {
        public FrmPrducaoSelecaoProduto()
        {
            InitializeComponent();
        }

        ClassConexao Conexao = new ClassConexao();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Conexao.AbreConexao();
            SqlCommand cmd = new SqlCommand("spProducaoProduto", conn);
            cmd.Parameters.AddWithValue("@Nome", TxtNome.Text);
            cmd.Parameters.AddWithValue("@CodProduto", TxtCodigo.Text);
            cmd.Parameters.AddWithValue("@CodImportado", TxtImportado.Text);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Open();
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                GridProduto.DataSource = data;
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

        public string CodigoProd { get; set; }
        public string CodigoProdImportado { get; set; }
        public string NomeProd { get; set; }
        public string MedidaProd { get; set; }
        public string QuantidadeProd { get; set; }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridProduto_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == GridProduto.Columns["Selecionar"].Index)
            {
                CodigoProd = Convert.ToString(GridProduto["Codigo", e.RowIndex].Value);
                CodigoProdImportado = Convert.ToString(GridProduto["CodigoImportado", e.RowIndex].Value);
                NomeProd = Convert.ToString(GridProduto["Nome", e.RowIndex].Value);
                MedidaProd = Convert.ToString(GridProduto["UnidadeMedida", e.RowIndex].Value);
                this.Close();
            }
        }
    }
}
