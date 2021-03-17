using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Scott_Basic_C_Sharp_Exercises
{
    class SsNum
    {
        public string Ss { get; set; }

        public void AssignSs( string input)
        {
            // remove non-number chars
            Regex rgx = new Regex("[^0-9 -]");
            string temp = rgx.Replace(input, "");

            if(temp.Length == 9)
            {
                Ss = temp;
            } else
            {
                throw new Exception("Not a valid SS number!!");
            }
            
        }

        public string FirstDigits()
        {

            return Ss.Substring(0, 5);
        }

        public string LastDigits()
        {
            return Ss.Substring(5);
        }

        public string Secure()
        {
            return ("****" + this.LastDigits());
        }
    }
}
