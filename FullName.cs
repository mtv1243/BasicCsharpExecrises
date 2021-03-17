using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scott_Basic_C_Sharp_Exercises
{
    class FullName
    {
        public string Name { get; set; }

        public void AssignName(string nameInput)
        {
            Name = nameInput;
        }

        public string Upper()
        {
            return Name.ToUpper().TrimEnd();
        }

        public string Lower()
        {
            return Name.ToLower().TrimEnd();
        }

        public int NameLength()
        {
            return Name.Trim().Length;
        }

        public int FirstSpace()
        {
            return Name.Trim().IndexOf(" ");
        }

        public int LastSpace()
        {
            return Name.Trim().LastIndexOf(" ");
        }
    }

}
