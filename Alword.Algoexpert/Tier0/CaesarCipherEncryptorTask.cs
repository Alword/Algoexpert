using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Algoexpert.Tier0
{
    public class CaesarCipherEncryptorTask
    {
        public static string CaesarCypherEncryptor(string str, int key)
        {
            int first = 'a';
            int length = 'z' - first + 1;
            StringBuilder stringBuilder = new StringBuilder(str.Length);
            // Write your code here.
            for (int i = 0; i < str.Length; i++)
            {
                stringBuilder.Append((char)(((str[i] - first + key) % length) + first));
            }
            return stringBuilder.ToString();
        }
    }
}
