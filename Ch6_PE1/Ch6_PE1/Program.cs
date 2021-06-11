using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch6_PE1
{
    class Program
    {
        static void Main()
        {
            int integer = 0;
            int otherCnt = 0;
            int rangeCnt = 0;
            int totalEntry = 0;
            string other = "";
            string range = "";
            string validInteger = "";

            Write("Enter the integer less than 100: <N to finish entry and display the result> ");
            string inValue = ReadLine();

            while (inValue != "N")
            {
                if (int.TryParse(inValue, out integer) == false || integer < 0 || integer > 99)
                {
                    if (integer < 0 || integer > 99)
                    {
                        WriteLine("Invalid data, data is out of range.");
                        rangeCnt++;
                        range += inValue + "\t";
                    }
                    else
                    {
                        WriteLine("Invalid data, data type is wrong.");
                        otherCnt++;
                        other += inValue + "\t";
                    }

                }

                else
                {

                    validInteger += inValue + "\t" ;
                }

                totalEntry++;

                Write("Enter the integer less than 100: <N to finish entry and display the result> ");
                inValue = ReadLine();


            }

            int validCnt = totalEntry - otherCnt - rangeCnt;
            Clear();

            WriteLine("out of range: \n" + range);


            WriteLine("\nwrong data type: \n" + other);


            WriteLine("\nvalid integer: \n" + validInteger);

            WriteLine("-------------------------------------------------------------------------");

            WriteLine("valid count" + "\t" + "Wrong type" + "\t" + "Out Of Range");

            WriteLine(validCnt + "\t\t\t" + otherCnt + "\t\t" + rangeCnt);

            ReadKey();






        }
    }
}
