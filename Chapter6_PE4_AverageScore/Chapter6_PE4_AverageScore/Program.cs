    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chapter6_PE4_AverageScore
{
    class Program
    {
        static void Main()
        {
            string inValue;
            int score;
            int i = 0;
            int totalScore = 0;
            double average;
            string anotherScore;
            do
            {
                GetValue(out inValue);

                while (int.TryParse(inValue, out score) == false || score < 0 || score>100) 
                {
                    Write("Invalid input, please make sure the score is Integer and between 0 and 100");
                    Write("\nRe-enter your score:");
                    inValue = ReadLine();
                }

                totalScore += score;
                i++;
                Write("Do you want to enter another score? <Y or N>: ");
                anotherScore = ReadLine();
            }
            while (anotherScore == "Y" || anotherScore == "y");

            average = (double) totalScore / i;
            Write("{0} \n", average); //only show for proof-reading

            if (average >= 90)
            {
                WriteLine("Grade: A");
                ReadKey();
            }
            else
                if (average >= 80)
            {
                WriteLine("Grade: B");
                ReadKey();
            }
            else 
                if (average >= 70)
            {
                WriteLine("Grade: C");
                ReadKey();
            }
            else
                if (average >= 60)
            {
                WriteLine("Grade: D");
                ReadKey();
            }
            else
            {
                WriteLine("Grade: F");
                ReadKey();
            }



        }

        static void GetValue(out string inValue) 
        {
            Write("Enter scores <0-100, integer>:");
            inValue = ReadLine();        
        }
    }
}
