using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectionSystems2.Classes
{
    class ClassUtilidades
    {
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
            get { return "DirectionSystems - 1.0.0"; }
        }
    }
}
