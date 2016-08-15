using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace DirectionSystems2.Classes
{
    class ClassCriptoArq
    {
        //fonte: https://support.microsoft.com/pt-br/kb/307010
        public bool EncryptFile(string Conteudo, string sOutputFilename)
        {
            if (System.IO.File.Exists(@sOutputFilename))
            {
                System.IO.File.Delete(@sOutputFilename);
            }
            System.IO.File.WriteAllText(@"C:\DirectionSystems2\Temp.ini", Conteudo);

            string sKey = "78Y4MSUM";

            FileStream fsInput = new FileStream(@"C:\DirectionSystems2\Temp.ini", FileMode.Open, FileAccess.Read);
            FileStream fsEncrypted = new FileStream(sOutputFilename, FileMode.Create, FileAccess.Write);

            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            ICryptoTransform desencrypt = DES.CreateEncryptor();
            CryptoStream cryptostream = new CryptoStream(fsEncrypted, desencrypt, CryptoStreamMode.Write);

            byte[] bytearrayinput = new byte[fsInput.Length];
            fsInput.Read(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Close();
            fsInput.Close();
            fsEncrypted.Close();
            System.IO.File.Delete(@"C:\DirectionSystems2\Temp.ini");

            if (System.IO.File.Exists(@sOutputFilename))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public StreamReader DecryptFile(string sInputFilename)
        {
            string sKey = "78Y4MSUM";
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            //A chave de 64 bits e IV é necessário para esse provedor.
            //Definir chave secreta para o algoritmo DES.
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            //Set vector de inicialização .
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);

            //Criar um fluxo de arquivo para ler o arquivo criptografado de volta.
            FileStream fsread = new FileStream(sInputFilename, FileMode.Open, FileAccess.Read);

            //Criar um decryptor DES da instância DES.
            ICryptoTransform desdecrypt = DES.CreateDecryptor();
            //Criar conjunto de fluxo de criptografia para ler e fazer um
            //// Descriptografia DES transformar em bytes de entrada.
            CryptoStream cryptostreamDecr = new CryptoStream(fsread, desdecrypt, CryptoStreamMode.Read);

            return new StreamReader(cryptostreamDecr);
        }
    }
}
