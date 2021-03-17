using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scott_Basic_C_Sharp_Exercises
{
    class Age
    {
        int UserAge { get; set; } = 0;
        int FatherAge { get; set; } = 0;
        int MotherAge { get; set; } = 0;

        public int CalcFatherDiff()
        {
            return FatherAge - UserAge;
        }

        public int CalcMotherDiff()
        {
            return MotherAge - UserAge;
        }

        public void AssignAge( string input)
        {
            int age = Convert.ToInt32(input);

            if(UserAge == 0)
            {
                UserAge = age;

            } else if(FatherAge == 0)
            {
                FatherAge = age;

            } else if(MotherAge == 0)
            {
                MotherAge = age;
            }
        }
    }
}
