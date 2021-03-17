using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scott_Basic_C_Sharp_Exercises
{
    class Birthday
    {
        public int UserYear { get; set; }
        public int UserMonth { get; set; }
        public int UserDay { get; set; }
        public DateTime UserBDay { get; set; }
        public DateTime FatherBDay { get; set; }
        public DateTime Now { get; } = DateTime.Now;

        public void Populate()
        {
            Console.WriteLine("In what month were you born? (number)");
            UserMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("On what day of that month were you born?");
            UserDay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("In what year were you born?");
            UserYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your father's birthday? (MM/DD/YYYY)");
            FatherBDay = DateTime.Parse(Console.ReadLine());

            UserBDay = new DateTime(UserYear, UserMonth, UserDay);

        }

        public void PrintBDays()
        {
            Console.WriteLine("Your birthday was {0}, a {1} in {2}", UserBDay.ToShortDateString(), UserBDay.DayOfWeek, UserBDay.ToString("MMMM"));
            Console.WriteLine("Your father's birthday was {0}, a {1} in {2}", FatherBDay.ToShortDateString(), FatherBDay.DayOfWeek, FatherBDay.ToString("MMMM"));
        }

        public void PrintNow()
        {
            Console.WriteLine("Today is {0}, {1} {2}, {3}", Now.DayOfWeek, Now.Month, Now.Day, Now.Year);
            Console.WriteLine("The time is {0}:{1}", Now.Hour, Now.Minute);
        }

        public void PrintNewtime()
        {
            Console.WriteLine("Please provide a number");
            string days = Console.ReadLine();
            int addDays = Int32.Parse(days);
            DateTime newDate = Now.AddDays(addDays);

            Console.WriteLine("In {0} days it will be a {1}.", days, newDate.DayOfWeek);
            Console.WriteLine("In {0} days it will {1}.", days, newDate.ToString("MMMM"));
            Console.WriteLine("In {0} days it will be the {1} of the month.", days, newDate.Day);
            Console.WriteLine("In {0} days it will be {1}.", days, newDate.Year);



        }

    }
}
