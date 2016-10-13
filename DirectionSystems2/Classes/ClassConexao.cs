using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace DirectionSystems2.Classes
{
    class ClassConexao
    {
        string Arquivo = (@"C:\DirectionSystems2\Configuracao.ini");
        ClassArquivoIni ini = new ClassArquivoIni();
        public SqlConnection AbreConexao()
        {
            string Servidor = MontaServidor();
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

        private string MontaServidor()
        {
            
            //string Servidor = string.Concat("192.168.0.102", "\\", ini.PesquisaIni(Arquivo, "Instancia"));
            return string.Concat(ini.PesquisaIni(Arquivo, "Servidor"), "\\", ini.PesquisaIni(Arquivo, "Instancia"));
        }

        public  Server GetServer()
        {
            string Servidor = MontaServidor();
            string Usuario = ini.PesquisaIni(Arquivo, "Usuario").ToLower();
            string Senha = ini.PesquisaIni(Arquivo, "Senha").ToLower();
            ServerConnection conn = new ServerConnection("DESKTOP-VAVJVPI\\SQLEXPRESS", Usuario, Senha);
            Server myServer = new Server(conn);
            return myServer;
        }
    }
}
