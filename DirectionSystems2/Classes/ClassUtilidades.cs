using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectionSystems2.Classes
{
    class ClassUtilidades
    {
        ClassCriptoTexto CitptoTexto = new ClassCriptoTexto();
        public static string codUsuario;
        public static string CodUsuario
        {
            get { return codUsuario; }
            set { codUsuario = value; }
        }

        public static string nomeUsuario;
        public static string NomeUsuario
        {
            get { return nomeUsuario; }
            set { nomeUsuario = value; }
        }

        public static string versao;
        public static string VersaoSistema
        {
            get { return "DirectionSystems - 0.8.2"; }
        }


        public static string usuario;
        public static string User
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public static string senha;
        public static string Password
        {
            get { return  senha; }
            set { senha = value; }
        }
    }
}
