using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvizhSeller.tools
{
    class Connverter
    {
        public static String ToUTF8(string input)
        {
            Encoding ecdng = Encoding.Default;

            byte[] bts = ecdng.GetBytes(input);
            ecdng = Encoding.UTF8;

            return ecdng.GetString(bts, 0, bts.Length);
        }

        public static String FromUTF8(string input)
        {
            Encoding ecdng = Encoding.UTF8;

            byte[] bts = ecdng.GetBytes(input);
            ecdng = Encoding.Default;

            return ecdng.GetString(bts, 0, bts.Length);
        }
    }
}
