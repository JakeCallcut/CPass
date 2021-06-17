using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CPass
{
    class Hashing
    {
        public static string GetSalt(string _username)
        {
            string salt = "";
            for (int i = 0; i < _username.Length; i++)
            {
                int AsciiCode = (int)Convert.ToChar(_username.Substring(i, 1));
                AsciiCode = AsciiCode + 4;
                salt = salt + Convert.ToString(AsciiCode);
            }

            return salt;
        }

    }
}
