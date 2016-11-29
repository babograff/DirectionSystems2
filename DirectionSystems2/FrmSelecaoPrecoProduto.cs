using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DirectionSystems2.Classes;
using System.Data.SqlClient;
using System.Linq;

namespace DirectionSystems2
{
    public partial class FrmSelecaoPrecoProduto : Form
    {
        public FrmSelecaoPrecoProduto()
        {
            InitializeComponent();
        }

        ClassConexao Conexao = new ClassConexao();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Conexao.AbreConexao();
            SqlCommand cmd = new SqlCommand("spPrecoProduto", conn);
            cmd.Parameters.AddWithValue("@Nome", TxtNome.Text);
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == GridProduto.Columns["Selecionar"].Index)
            {
                CodProdutoPreco = Convert.ToString(GridProduto["Codigo", e.RowIndex].Value);
                CodigoProdImportadoPreco = Convert.ToString(GridProduto["CodigoImportado", e.RowIndex].Value);
                NomePreco = Convert.ToString(GridProduto["Nome", e.RowIndex].Value);
                ValorPreco = Convert.ToString(GridProduto["Valor", e.RowIndex].Value);
                MedidaPreco = Convert.ToString(GridProduto["UnidadeMedida", e.RowIndex].Value);
                QuantidadePreco = Convert.ToString(GridProduto["Quantidade", e.RowIndex].Value);
                this.Close();
            }
        }

        public string CodProdutoPreco { get; set; }
        public string CodigoProdImportadoPreco { get; set; }
        public string NomePreco { get; set; }
        public string ValorPreco { get; set; }
        public string MedidaPreco { get; set; }
        public string QuantidadePreco { get; set; }
    }
}
