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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
