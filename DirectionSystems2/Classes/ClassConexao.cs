using System.Data.SqlClient;

namespace DirectionSystems2.Classes
{
    class ClassConexao
    {
        public SqlConnection AbreConexao()
        {
            ClassArquivoIni ini = new ClassArquivoIni();
            string Arquivo = (@"C:\DirectionSystems2\Configuracao.ini");

            string Servidor = string.Concat(ini.PesquisaIni(Arquivo, "Servidor"), "\\", ini.PesquisaIni(Arquivo, "Instancia"));
            string Banco = ini.PesquisaIni(Arquivo, "BancoDados");
            string Usuario = ini.PesquisaIni(Arquivo, "Usuario").ToLower();
            string Senha = ini.PesquisaIni(Arquivo, "Senha").ToLower();
            string stringconexao = "Data Source=" + Servidor + ";Initial Catalog=" + Banco + ";User ID=" + Usuario + ";Password=" + Senha + ";Language=Portuguese";
            SqlConnection conn = new SqlConnection(stringconexao);
            conn.Open();
            return conn;
        }

        public void FechaConexao(SqlConnection conn)
        {
            conn.Close();
        }
    }
}
