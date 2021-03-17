using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scott_Basic_C_Sharp_Exercises
{
    class Wage
    {
        public decimal HourlyWage { get; set; } = 0m;
        public decimal HoursWorked { get; set; } = 0m;
        public decimal WeeksUnpaid { get; set; } = 0m;

        private decimal temp;

        public void ParseHourlyWage(string str)
        {
            if (Decimal.TryParse(str, out temp))
            {
                HourlyWage = temp;
            }
            else
            {
                Console.WriteLine("Not a valid number!");
            } 
        }
        public void ParseHoursWorked(string str)
        {
            if (Decimal.TryParse(str, out temp))
            {
                HoursWorked = temp;
            }
            else
            {
                Console.WriteLine("Not a valid number!");
            }
        }

        public void ParseWeeksUnpaid(string str)
        {
            if (Decimal.TryParse(str, out temp))
            {
                WeeksUnpaid = temp;
            }
            else
            {
                Console.WriteLine("Not a valid number!");
            }
        }

        public decimal CalculateWage()
        {

            if (HourlyWage == 0 || WeeksUnpaid == 0 || HoursWorked == 0)
            {
                Console.WriteLine("Need more numbers!");
                return -1;
            }

            decimal weeklyPay = HourlyWage * HoursWorked;
            return (weeklyPay * 52) - (weeklyPay * WeeksUnpaid);
        }

    }
}
