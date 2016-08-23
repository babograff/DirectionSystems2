using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace DirectionSystems2.Classes
{
    class ClassArquivoIni
    {
        public String PesquisaIni(String Arquivo, String Variavel)
        {
            Variavel = Variavel + "=";
            List<String> GrupoVariavel;

            String iniFile = null;
            if (File.Exists(Arquivo))
            {
                try
                {
                    ClassCriptoArq arquivo = new ClassCriptoArq();
                    iniFile = (String)arquivo.DecryptFile(Arquivo).ReadToEnd();
                    GrupoVariavel = iniFile.Split('|').ToList();
                    Variavel = GrupoVariavel.Find(x => x.Contains(Variavel)).Replace(Variavel, "");
                    return Variavel;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            else
            {
                throw new FileNotFoundException("Arquivo de configuração não existe!");
            }
        }
    }
}
