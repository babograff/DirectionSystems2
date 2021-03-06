﻿using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DirectionSystems2.Properties;
using DirectionSystems2.Classes;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace DirectionSystems2
{
    public partial class FrmCadastroClienteFornecedor : Form
    {
        ClassConexao Conexao = new ClassConexao();
        SqlDataReader reader;
        public FrmCadastroClienteFornecedor(int Codigo)
        {
            InitializeComponent();
            LblTitulo.Text = ClassUtilidades.VersaoSistema;

            TxtCPFCNPJ.Focus();

            SqlConnection conn = Conexao.AbreConexao();
            SqlCommand cmd = new SqlCommand("spUF", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Open();
                DataTable dtResultado = new DataTable();
                reader = cmd.ExecuteReader();
                dtResultado.Clear();//o ponto mais importante (limpa a table antes de preenche-la)
                dtResultado.Load(reader);
                CboUF.DataSource = null;
                CboUF.DataSource = dtResultado;
                CboUF.ValueMember = "CodUF";
                CboUF.DisplayMember = "UF";
                CboUF.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                Conexao.FechaConexao(conn);
            }

            if (Codigo == 0)
            {
                TxtCodigo.Text = "Novo";
                CboStatus.SelectedIndex = 1;
                Fornecedor.Checked = true;
            }
            else
            {
                TxtCodigo.Text = Codigo.ToString();
                conn = Conexao.AbreConexao();
                cmd = new SqlCommand("spClienteFornecedorInterna", conn);
                cmd.Parameters.AddWithValue("@CodClienteFornecedor", Codigo);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    conn.Open();
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        TxtCodigoImportado.Text = reader[0].ToString();
                        CboUF.SelectedValue = Convert.ToInt32(reader[1]);
                        TxtNome.Text = reader[2].ToString();
                        TxtTelefone.Text = reader[3].ToString();
                        TxtEmail.Text = reader[4].ToString();
                        TxtCidade.Text = reader[5].ToString();
                        TxtBairro.Text = reader[6].ToString();
                        TxtFantasia.Text = reader[7].ToString();
                        TxtFax.Text = reader[8].ToString();
                        TxtSite.Text = reader[9].ToString();
                        // TxtNascimento.Text = reader[10].ToString();
                        Cliente.Checked = Convert.ToBoolean(reader[11]);
                        Fornecedor.Checked = Convert.ToBoolean(reader[12]);
                        TxtEndereco.Text = reader[13].ToString();
                        TxtCPFCNPJ.Text = reader[14].ToString();
                        TxtRG.Text = reader[15].ToString();
                        CboStatus.SelectedIndex = CboStatus.Items.IndexOf(reader[16].ToString());

                    }
                    else
                    {
                        MessageBox.Show("Usuário inexistente");
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

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_LBUTTONDOWN)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void FrmCadastroClienteFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu Menu = new FrmMenu();
            Menu.Visible = true;
            this.Close();
        }

        private void BtnClienteFornecedor_Click(object sender, EventArgs e)
        {
            FrmSelecaoClienteFornecedor ClienteFornecedor = new FrmSelecaoClienteFornecedor();
            ClienteFornecedor.Visible = true;
            this.Close();
        }

        private void BtnProduto_Click(object sender, EventArgs e)
        {
            FrmSelecaoProduto Produto = new FrmSelecaoProduto();
            Produto.Visible = true;
            this.Close();
        }

        private void BtnFuncionario_Click(object sender, EventArgs e)
        {
            FrmSelecaoFuncionario Funcionario = new FrmSelecaoFuncionario();
            Funcionario.Visible = true;
            this.Close();
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            FrmSelecaoUsuario Usuario = new FrmSelecaoUsuario();
            Usuario.Visible = true;
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

        private void BtnClienteFornecedor_MouseHover(object sender, EventArgs e)
        {
            BtnClienteFornecedor.Image = Resources.MenuClienteFornecedorAtivo;
        }

        private void BtnClienteFornecedor_MouseLeave(object sender, EventArgs e)
        {
            BtnClienteFornecedor.Image = Resources.MenuClienteFornecedor;
        }

        private void BtnProduto_MouseHover(object sender, EventArgs e)
        {
            BtnProduto.Image = Resources.MenuProdutoAtivo;
        }

        private void BtnProduto_MouseLeave(object sender, EventArgs e)
        {
            BtnProduto.Image = Resources.MenuProduto;
        }

        private void BtnFuncionario_MouseHover(object sender, EventArgs e)
        {
            BtnFuncionario.Image = Resources.MenuFuncionarioAtivo;
        }

        private void BtnFuncionario_MouseLeave(object sender, EventArgs e)
        {
            BtnFuncionario.Image = Resources.MenuFuncionario;
        }

        private void BtnUsuario_MouseHover(object sender, EventArgs e)
        {
            BtnUsuario.Image = Resources.MenuUsuarioAtivo;
        }

        private void BtnUsuario_MouseLeave(object sender, EventArgs e)
        {
            BtnUsuario.Image = Resources.MenuUsuario;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                string Codigo;
                if (TxtCodigo.Text == "Novo")
                {
                    Codigo = "0";
                }
                else
                {
                    Codigo = TxtCodigo.Text;
                }



                SqlConnection conn = Conexao.AbreConexao();
                SqlCommand cmd = new SqlCommand("spClienteFornecedorNovo", conn);
                cmd.Parameters.AddWithValue("@CodClienteFornecedor", Codigo);
                cmd.Parameters.AddWithValue("@CodUF", CboUF.SelectedValue);
                cmd.Parameters.AddWithValue("@Nome", TxtNome.Text);
                cmd.Parameters.AddWithValue("@Email ", TxtEmail.Text);
                cmd.Parameters.AddWithValue("@Cidade", TxtCidade.Text);
                cmd.Parameters.AddWithValue("@Bairro", TxtBairro.Text); //verificar depois
                cmd.Parameters.AddWithValue("@Status", CboStatus.SelectedIndex);
                cmd.Parameters.AddWithValue("@CodImportado", TxtCodigoImportado.Text);
                cmd.Parameters.AddWithValue("@Fantasia", TxtFantasia.Text);
                cmd.Parameters.AddWithValue("@Fax", TxtFax.Text);
                cmd.Parameters.AddWithValue("@Site", TxtSite.Text);
                cmd.Parameters.AddWithValue("@Nascimento", "");
                cmd.Parameters.AddWithValue("@Telefone", TxtTelefone.Text);
                cmd.Parameters.AddWithValue("@TipoCliente", Cliente.Checked);
                cmd.Parameters.AddWithValue("@TipoFornecedor", Fornecedor.Checked);
                cmd.Parameters.AddWithValue("@Endereco", TxtEndereco.Text);
                cmd.Parameters.AddWithValue("@CPFCNPJ", TxtCPFCNPJ.Text);
                cmd.Parameters.AddWithValue("@RGINSC", TxtRG.Text);



                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    conn.Open();
                    if (TxtCodigo.Text != "Novo")
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                            MessageBox.Show("Registro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Registro não encontrado para atualização", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            TxtCodigo.Text = reader[0].ToString();
                            MessageBox.Show("Registro incuído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
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

        private bool Valida()
        {
            if (TxtCPFCNPJ.Text == string.Empty)
            {
                MessageBox.Show("Campo CPF / CNPJ  vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCPFCNPJ.Focus();
                return false;
            }
            else if (TxtNome.Text == string.Empty)
            {
                MessageBox.Show("Campo NOME vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNome.Focus();
                return false;
            }
            return true;
        }

        private void TxtCPFCNPJ_Leave(object sender, EventArgs e)
        {
            TxtCPFCNPJ.Text = MascaraCnpjCpf(TxtCPFCNPJ.Text);
        }

        public static string MascaraCnpjCpf(string pCnpjCpf)
        {
            string result = "";
            if (pCnpjCpf.Length == 14)
            {
                result = pCnpjCpf.Insert(2, ".").Insert(6, ".").Insert(10, "/").Insert(15, "-");
            }
            if (pCnpjCpf.Length == 11)
            {
                result = pCnpjCpf.Insert(3, ".").Insert(7, ".").Insert(11, "-");
            }
            if ((pCnpjCpf.Length != 11) && (pCnpjCpf.Length != 14))
            {
                result = pCnpjCpf;
            }
            return result;
        }

        private void TxtCPFCNPJ_Enter(object sender, EventArgs e)
        {
            Regex rgx = new Regex("[^0-9a-zA-Z]+");
            TxtCPFCNPJ.Text = rgx.Replace(TxtCPFCNPJ.Text, "");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmSelecaoClienteFornecedor ClienteFornecedor = new FrmSelecaoClienteFornecedor();
                ClienteFornecedor.Show();
                this.Close();
            }
        }
    }
}
