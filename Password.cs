using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Scott_Basic_C_Sharp_Exercises
{
    class Password
    {
        public string PassPhrase { get; set; }
        public string Number { get; set; }
        public string ParsedPassword { get; set; }

        public void AssignPassPhrase(string passPhrase)
        {
            PassPhrase = passPhrase;
        }

        public void AssignNumber(string number)
        {
            Number = number;
        }

        public string ParsePassword()
        {
            Regex rgxSpace = new Regex("/ /gm");
            ParsedPassword = rgxSpace.Replace(PassPhrase, "");

            Regex rgxA = new Regex("/a/gmi");
            ParsedPassword = rgxSpace.Replace(PassPhrase, "2");

            Regex rgxO = new Regex("/o/gmi");
            ParsedPassword = rgxSpace.Replace(PassPhrase, "0");

            Regex rgxI = new Regex("/i/gmi");
            ParsedPassword = rgxSpace.Replace(PassPhrase, "!");

            //char[] numArr = Number.ToCharArray();

            ParsedPassword = Number[0] + ParsedPassword + Number[Number.Length-1];

            return ParsedPassword;
        }
    }
}
