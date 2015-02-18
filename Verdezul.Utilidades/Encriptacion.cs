using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace Verdezul.Utilidades
{
    public static class Encriptacion
    {
        public static string MD5(String input)
        {
            MD5CryptoServiceProvider Hasher = new MD5CryptoServiceProvider();
            Byte[] data = Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            foreach (Byte i in data)
            {
                sBuilder.Append(i.ToString("x2"));
            }
            return sBuilder.ToString();
        }

        public static string SHA(String input)
        {
            SHA1CryptoServiceProvider Hasher = new SHA1CryptoServiceProvider();
            Byte[] data = Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            foreach (Byte i in data)
            {
                sBuilder.Append(i.ToString("x2"));
            }
            return sBuilder.ToString();
        }

        public static string EncriptarCadenaConexion(String input)
        {
            return input;
        }
        public static string DesncriptarCadenaConexion(String input)
        {
            return input;
        }
    
    }
}
