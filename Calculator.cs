using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scott_Basic_C_Sharp_Exercises
{
    class Calculator
    {
        public double? Int1 { get; set; } = null;
        public double? Int2 { get; set; } = null;

        public double? Add { get; set; }
        public double? Sub { get; set; }
        public double? Mult { get; set; }
        public double? Div { get; set; }

        public void ParseInput(string input)
        {
            if(Int1 == null)
            {
                Int1 = Convert.ToDouble(input);
            } 
            else
            {
                Int2 = Convert.ToDouble(input);
            }
        }

        public void Calculate()
        {
            if(Int1 != null && Int2 != null)
            {
                Add = (Int1 + Int2);
                Sub = (Int1 - Int2);
                Mult = (Int1 * Int2);
                Div = (Int1 / Int2);
            }
            else
            {
                throw new Exception("Have you entered TWO numbers?");
            }
            
        }

    }
}
