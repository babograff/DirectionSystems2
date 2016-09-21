using System;
using System.Data;
using System.Windows.Forms;
using DirectionSystems2.Classes;
using System.Data.OleDb;
using System.IO;
using System.Data.SqlClient;


namespace DirectionSystems2
{
    public partial class FrmImportacao : Form
    {
        public FrmImportacao()
        {
            InitializeComponent();
            LblTitulo.Text = ClassUtilidades.VersaoSistema;
            CboTabela.SelectedIndex = 0;
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

        private void FrmImportacao_Load(object sender, EventArgs e)
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

        ClassConexao Conexao = new ClassConexao();
        SqlDataReader reader;
        private void BtnImportar_Click(object sender, EventArgs e)
        {
            if (TabelaImportacao == null)
            {
                MessageBox.Show(this, "Leia o arquivo antes de salvar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int OK = 0;
                int Erro = 0;
                progressBar1.Style = ProgressBarStyle.Blocks;
                progressBar1.Step = 1;

                if (CboTabela.SelectedItem.ToString() == "Vendas")
                {
                    if (TxtNomeArquivo.Text.Contains("PVEND001"))
                    {
                        progressBar1.Maximum = Convert.ToInt32(TabelaImportacao.Rows.Count);
                        foreach (DataRow row in TabelaImportacao.Rows)
                        {
                            SqlConnection conn = Conexao.AbreConexao();
                            SqlCommand cmd = new SqlCommand("spVendaNovo", conn);
                            cmd.Parameters.AddWithValue("@CodImportado ", row["N_DOCTO"]);
                            cmd.Parameters.AddWithValue("@CodProdutoImportado ", row["COD_PRO"]);
                            cmd.Parameters.AddWithValue("@DataVenda ", row["DATA_VEND"]);
                            cmd.Parameters.AddWithValue("@Quantidade", row["QTE"]);
                            cmd.Parameters.AddWithValue("@Valor", row["P_VENDA"]);
                            cmd.CommandType = CommandType.StoredProcedure;

                            try
                            {
                                int i = cmd.ExecuteNonQuery();
                                if (i > 0)
                                    OK++;
                                else
                                    Erro++;
                                progressBar1.PerformStep();

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
                        MessageBox.Show(this, "Importação de " + TabelaImportacao.Rows.Count + " concluída! \nImportado: " + OK + "\nNão Importado: " + Erro, "Fim de importação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(this, "A planilha selecionada não é de vendas!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (CboTabela.SelectedItem.ToString() == "Produtos")
                {
                    if (TxtNomeArquivo.Text.Contains("PRODUTOS"))
                    {
                        progressBar1.Maximum = Convert.ToInt32(TabelaImportacao.Rows.Count);
                        foreach (DataRow row in dt.Rows)
                        {
                            SqlConnection conn = Conexao.AbreConexao();
                            SqlCommand cmd = new SqlCommand("spProdutoNovoImportacao", conn);
                            cmd.Parameters.AddWithValue("@CodImportado", row["COD_PRO"]);
                            cmd.Parameters.AddWithValue("@Medida", row["UNIDADE"]);
                            cmd.Parameters.AddWithValue("@Nome", row["NOME"]);
                            cmd.Parameters.AddWithValue("@Descricao", row["NOME"]);
                            cmd.CommandType = CommandType.StoredProcedure;

                            try
                            {
                                int i = cmd.ExecuteNonQuery();
                                if (i > 0)
                                    OK++;
                                else
                                    Erro++;
                                progressBar1.PerformStep();

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
                        MessageBox.Show(this, "Importação de " + TabelaImportacao.Rows.Count + " concluída! \nImportado: " + OK + "\nNão Importado: " + Erro, "Fim de importação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(this, "A planilha selecionada não é de produtos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (CboTabela.SelectedItem.ToString() == "Clientes")
                {
                    if (TxtNomeArquivo.Text.Contains("CLIENTES"))
                    {
                        progressBar1.Maximum = Convert.ToInt32(TabelaImportacao.Rows.Count);
                        foreach (DataRow row in dt.Rows)
                        {
                            SqlConnection conn = Conexao.AbreConexao();
                            SqlCommand cmd = new SqlCommand("spClienteFornecedorNovoImportacao", conn);
                            cmd.Parameters.AddWithValue("@CodImportado", row["COD_CLI"]);
                            cmd.Parameters.AddWithValue("@UF", row["ESTADO"]);
                            cmd.Parameters.AddWithValue("@Nome", row["NOME"]);
                            cmd.Parameters.AddWithValue("@CPFCNPJ", row["CGC_CPF"]);
                            cmd.Parameters.AddWithValue("@RGINSC", row["INSC_RG"]);
                            cmd.Parameters.AddWithValue("@Telefone", row["FONE"]);
                            cmd.Parameters.AddWithValue("@Email", row["E_MAIL"]);
                            cmd.Parameters.AddWithValue("@Cidade", row["CIDADE"]);
                            cmd.Parameters.AddWithValue("@Bairro", row["BAIRRO"]);
                            cmd.Parameters.AddWithValue("@Endereco", row["ENDERECO"]);
                            cmd.Parameters.AddWithValue("@Fantasia", "");
                            cmd.Parameters.AddWithValue("@Site", "");
                            cmd.Parameters.AddWithValue("@Fax", "");
                            cmd.Parameters.AddWithValue("@TipoCliente", 1);
                            cmd.Parameters.AddWithValue("@TipoFornecedor", 0);
                            cmd.CommandType = CommandType.StoredProcedure;

                            try
                            {
                                int i = cmd.ExecuteNonQuery();
                                if (i > 0)
                                    OK++;
                                else
                                    Erro++;
                                progressBar1.PerformStep();

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
                        MessageBox.Show(this, "Importação de " + TabelaImportacao.Rows.Count + " concluída! \nImportado: " + OK + "\nNão Importado: " + Erro, "Fim de importação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(this, "A planilha selecionada não é de clientes!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (CboTabela.SelectedItem.ToString() == "Fornecedor")
                {
                    if (TxtNomeArquivo.Text.Contains("FORNECED"))
                    {
                        progressBar1.Maximum = Convert.ToInt32(TabelaImportacao.Rows.Count);
                        foreach (DataRow row in dt.Rows)
                        {
                            SqlConnection conn = Conexao.AbreConexao();
                            SqlCommand cmd = new SqlCommand("spClienteFornecedorNovoImportacao", conn);
                            cmd.Parameters.AddWithValue("@CodImportado", row["COD_FOR"]);
                            cmd.Parameters.AddWithValue("@UF", row["ESTADO"]);
                            cmd.Parameters.AddWithValue("@Nome", row["NOME"]);
                            cmd.Parameters.AddWithValue("@CPFCNPJ", row["CGC_CPF"]);
                            cmd.Parameters.AddWithValue("@RGINSC", row["INSC_RG"]);
                            cmd.Parameters.AddWithValue("@Telefone", row["FONE"]);
                            cmd.Parameters.AddWithValue("@Email", row["E_MAIL"]);
                            cmd.Parameters.AddWithValue("@Cidade", row["CIDADE"]);
                            cmd.Parameters.AddWithValue("@Bairro", row["BAIRRO"]);
                            cmd.Parameters.AddWithValue("@Endereco", row["ENDERECO"]);
                            cmd.Parameters.AddWithValue("@Fantasia", row["FANTASIA"]);
                            cmd.Parameters.AddWithValue("@Site", row["HOMEPAGE"]);
                            cmd.Parameters.AddWithValue("@Fax", row["FAX"]);
                            cmd.Parameters.AddWithValue("@TipoCliente", 0);
                            cmd.Parameters.AddWithValue("@TipoFornecedor", 1);
                            cmd.CommandType = CommandType.StoredProcedure;

                            try
                            {
                                int i = cmd.ExecuteNonQuery();
                                if (i > 0)
                                    OK++;
                                else
                                    Erro++;
                                progressBar1.PerformStep();

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
                        MessageBox.Show(this, "Importação de " + TabelaImportacao.Rows.Count + " concluída! \n Importado: " + OK + "\n Não Importado: " + Erro, "Fim de importação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(this, "A planilha selecionada não é de fornecedores!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private static DataTable dt;
        public static DataTable TabelaImportacao
        {
            get { return dt; }
            set { dt = value; }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            using (FolderBrowserDialog dirDialog = new FolderBrowserDialog())
            {
                // Mostra a janela de escolha do directorio
                /*DialogResult res = dirDialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    // Como o utilizador carregou no OK, o directorio escolhido pode ser acedido da seguinte forma:
                    string directorio = dirDialog.SelectedPath;
                    TxtNomeArquivo.Text = directorio;
                    GridDados.DataSource = GetYourData(directorio, CboTabela.SelectedItem.ToString());
                }*/

                try
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "dBASE files (*.dbf)|*.dbf";
                    ofd.ShowDialog();

                    if (ofd.FileName.Length > 0)
                    {
                        TabelaImportacao = GetYourData(ofd.FileName, CboTabela.SelectedItem.ToString());
                        GridDados.DataSource = TabelaImportacao;
                        TxtNomeArquivo.Text = ofd.FileName;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Erro ao ler arquivo!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public DataTable GetYourData(string caminho, string Tabela)
        {
            string constr = "Provider=VFPOLEDB.1;Data Source=" + Directory.GetParent(caminho).FullName;
            string ExcelFileName = AppDomain.CurrentDomain.BaseDirectory + "converted_file.xls";
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                var sql = "select * from " + Path.GetFileName(caminho) + ";";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                DataTable dados = new DataTable();
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {

                }
                if (con.State == ConnectionState.Open)
                {
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(dados);

                }
                if (con.State == ConnectionState.Open)
                {
                    try
                    {
                        con.Close();
                    }
                    catch { }
                }
                return dados;
            }
        }
    }
}
