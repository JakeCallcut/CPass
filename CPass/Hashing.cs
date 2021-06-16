using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPass
{
    class Hashing
    {

        public static string Hash(string _plaintext, string _salt)
        {

        }

        public static bool Verify(string _hashedPass, string _salt)
        {

        }

        public static string GetSalt(string _username)
        {
            for (int i = 0; i < _username.Length; i++)
            {
                int AsciCode = (int)Convert.ToChar(_username.Substring(i, 1));
                AsciCode = AsciCode + 4;
            }
        }

    }
}
