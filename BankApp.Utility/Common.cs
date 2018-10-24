using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Utility
{
    public class Common
    {
        public static string GenerateMD5(string input)
        {
            StringBuilder sb = new StringBuilder();
            // step 1, calculate MD5 hash from input

            using (MD5 md5 = System.Security.Cryptography.MD5.Create())
            {

                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);

                byte[] hash = md5.ComputeHash(inputBytes);

                // step 2, convert byte array to hex string

                for (int i = 0; i < hash.Length; i++)

                {

                    sb.Append(hash[i].ToString("X2"));

                }
            }

            return sb.ToString();
        }
    }
}
