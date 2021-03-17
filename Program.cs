using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Scott_Basic_C_Sharp_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercises found at https://34653ed7-e00a-47f3-8cce-86ae1bf24993.filesusr.com/ugd/221460_f34738b795984ae992eb0d56b84e3f3f.pdf

            // EXERCISE 01
            // ===========================

            /*
            FullName fullName = new FullName();

            string q1 = "What is your full name?";
            Console.WriteLine(q1);
            string newName = Console.ReadLine();

            fullName.AssignName(newName);

            Console.WriteLine("upperCase: {0}", fullName.Upper());
            Console.WriteLine("lowerCase: {0}", fullName.Lower());
            Console.WriteLine("characters: {0}", fullName.NameLength());
            Console.WriteLine("firstSpaceIndex: {0}", fullName.FirstSpace());
            Console.WriteLine("lastSpaceIndex: {0}", fullName.LastSpace());
            */

            /*
            string q1 = "What is your full name?";
            Console.WriteLine(q1);
            string fullName = Console.ReadLine();

            string upper = fullName.ToUpper().TrimEnd();
            string lower = fullName.ToLower().TrimStart();
            int nameLength = fullName.Trim().Length;
            string noSpaces = fullName.Trim();
            int firstSpaceIndex = noSpaces.IndexOf(" ");
            int lastSpaceIndex = noSpaces.LastIndexOf(" ");

            Console.WriteLine("upperCase: {0}", upper);
            Console.WriteLine("lowerCase: {0}", lower);
            Console.WriteLine("characters: {0}", nameLength);
            Console.WriteLine("firstSpaceIndex: {0}", firstSpaceIndex);
            Console.WriteLine("lastSpaceIndex: {0}", lastSpaceIndex);
            */

            // EXERCISE 2
            // ===========================

            /*
            Console.WriteLine(" ");
            Console.WriteLine("=====================");
            Console.WriteLine("What is your social security number?");
            string ssInput = Console.ReadLine();

            SsNum ssNum = new SsNum();

            ssNum.AssignSs(ssInput);

            Console.WriteLine("first digits:{0}", ssNum.FirstDigits());
            Console.WriteLine("last digits:{0}", ssNum.LastDigits());
            Console.WriteLine("secure digits:{0}", ssNum.Secure());
            */


            /*
            Console.WriteLine("What is your social security number?");
            string ss = Console.ReadLine();

            // remove non-number chars
            Regex rgx = new Regex("[^0-9 -]");
            ss = rgx.Replace(ss, "");

            string firstDigits = ss.Substring(0, 5);
            string lastDigits = ss.Substring(5);
            string secureSs = "*****" + lastDigits;

            Console.WriteLine("first digits:{0}", firstDigits);
            Console.WriteLine("last digits:{0}", lastDigits);
            Console.WriteLine("secure digits:{0}", secureSs);
            */

            // EXERCISE 3
            // =============================

            /*
            Console.WriteLine(" ");
            Console.WriteLine("========================");
            Console.WriteLine("We will now create a password.");
            Console.WriteLine("enter a phrase below");

            Password password = new Password();

            string passPhrase = Console.ReadLine();

            Console.WriteLine("enter a number greater than 9 below");

            string number = Console.ReadLine();

            password.AssignPassPhrase(passPhrase);
            password.AssignNumber(number);

            Console.WriteLine("========================");
            Console.WriteLine("original phrase: {0}\n number: {1}\n new password: {2}", password.PassPhrase, password.Number, password.ParsePassword());
            */

            // =============================
            // NUMBERS 
            // EXERCISE 1
            // =============================

            /*
             * 
            Console.WriteLine(" ");
            Console.WriteLine("========================");

            Calculator calculator = new Calculator();

            Console.WriteLine("Enter a number:");

            calculator.ParseInput(Console.ReadLine());

            Console.WriteLine("Enter another number:");

            calculator.ParseInput(Console.ReadLine());

            calculator.Calculate();

            Console.WriteLine("{0} plus {1} equals {2}", calculator.Int1, calculator.Int2, calculator.Add);
            Console.WriteLine("{0} minus {1} equals {2}", calculator.Int1, calculator.Int2, calculator.Sub);
            Console.WriteLine("{0} times {1} equals {2}", calculator.Int1, calculator.Int2, calculator.Mult);
            Console.WriteLine("{0} divided by {1} equals {2}", calculator.Int1, calculator.Int2, calculator.Div);
            */

            // EXERCISE 2
            // =============================

            /*
            Console.WriteLine(" ");
            Console.WriteLine("========================");

            Age ages = new Age();

            Console.WriteLine("What is your age?");
            ages.AssignAge(Console.ReadLine());
            Console.WriteLine("What is your father's age?");
            ages.AssignAge(Console.ReadLine());
            Console.WriteLine("What is your mother's age?");
            ages.AssignAge(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Your father was {0} years old when you were born", ages.CalcFatherDiff());
            Console.WriteLine("Your mother was {0} years old when you were born", ages.CalcMotherDiff());
            */



            // EXERCISE 3
            // =============================

            /*
            Console.WriteLine(" ");
            Console.WriteLine("========================");
            
            Wage wage = new Wage();

            Console.WriteLine("What is your hourly wage?");
            wage.ParseHourlyWage(Console.ReadLine());

            Console.WriteLine("How many hours do you work in a week?");
            wage.ParseHoursWorked(Console.ReadLine());

            Console.WriteLine("How many weeks unpaid will you take?");
            wage.ParseWeeksUnpaid(Console.ReadLine());

            Console.WriteLine("You will make ${0} in one year.", wage.CalculateWage());
            */

            // DateTime and Timespan
            // =============================
            // Exercise 01
            Console.WriteLine(" ");
            Console.WriteLine("========================");

            Birthday birthday = new Birthday();

            // birthday.Populate();
            // birthday.PrintBDays();
            birthday.PrintNewtime();

            // Leave this here
            Console.ReadLine();

        }
    }
}
