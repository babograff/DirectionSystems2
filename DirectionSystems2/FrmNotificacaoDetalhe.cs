using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DirectionSystems2.Properties;
using DirectionSystems2.Classes;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace DirectionSystems2
{
    public partial class FrmNotificacaoDetalhe : Form
    {
        ClassConexao Conexao = new ClassConexao();
        SqlDataReader reader;
        public FrmNotificacaoDetalhe(int Codigo)
        {
            InitializeComponent();

            SqlConnection conn = Conexao.AbreConexao();
            SqlCommand cmd = new SqlCommand("spNotificacaoDetalhe", conn);
            cmd.Parameters.AddWithValue("@CodNotificacao", Codigo);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    TxtCodigo.Text = Codigo.ToString();
                    TxtData.Text = reader[0].ToString();
                    TxtNome.Text = reader[1].ToString();
                    TxtDescricao.Text = reader[2].ToString();
                }
                else
                {
                    MessageBox.Show("Notificação inexistente");
                }
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
    }
}
