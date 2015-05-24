using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace HashCounter
{
    public class HashCounter
    {
        public string createHash(byte[] data)
        {
            MD5 md5Hasher = MD5.Create();
            data = md5Hasher.ComputeHash(data);
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        public bool compareHash(byte[] data, string hash)
        {
            if (hash == createHash(data))
                return true;
            else
                return false;
        }
    }
}
