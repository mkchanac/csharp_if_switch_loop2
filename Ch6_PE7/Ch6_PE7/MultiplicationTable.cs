using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch6_PE7
{
    class MultiplicationTable
    {
        static void Main()
        {
            int firstBase;
            int lastBase;
            string inValue;
            string anotherTable;

            do
            {
                Write("Enter the first base value (range from 2 to 8): ");
                inValue = ReadLine();
                while (int.TryParse(inValue, out firstBase) == false || firstBase < 2 || firstBase > 8)
                {
                    Write("Invalid entry, please re-enter integer for the first base, from 2 to 8:");
                    inValue = ReadLine();
                }

                Write("Enter the last base value (range from 2 to 8): ");
                inValue = ReadLine();
                while (int.TryParse(inValue, out lastBase) == false || lastBase < 2 || lastBase > 8)
                {
                    Write("Invalid entry, please re-enter integer for the last base, from 2 to 8:");
                    inValue = ReadLine();
                }
                Clear();

                Write("n\t");
                for (int i = firstBase; i <= lastBase; i++)
                {
                    Write(i + "\t");
                }
                WriteLine();
                WriteLine();

                for (int n=1; n <26; n++)
                {
                    Write(n + "\t");
                    for (int i = firstBase; i <= lastBase; i++)
                    {
                        int total = i * n;
                        Write(total + "\t");
                    }

                    WriteLine();
                }

                WriteLine();
                Write("Do you want to generate another Multiplication Table? <Y or N> ");
                anotherTable = ReadLine();
                Clear();
            }
            while (anotherTable == "Y" || anotherTable == "y");

        }
    }
}
