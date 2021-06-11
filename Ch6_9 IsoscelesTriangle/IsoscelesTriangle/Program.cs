using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace IsoscelesTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            char chr = '#';
            int peak = 3;
            string moreTriangle = "";

            do
            {
                Write("Enter the character <1 character only>: ");
                if (char.TryParse(ReadLine(), out chr) == false)
                { 
                    WriteLine("Invalid entry, # is stored for the character.");

                    chr = '#';
                }

                Write("Enter the peak of triangle <integer and maximum 10>: ");
                if (int.TryParse(ReadLine(), out peak) == false || peak > 10 || peak <= 0)
                {
                    WriteLine("Invalid entry, 3 is stored for the peak.");
                    WriteLine();
                    WriteLine("Press any key to continue...");
                    ReadKey();
                    peak = 3;
                }
                Write("Press any key to contiune...");
                Clear();
                for (int i = 1; i <= peak; i++) 
                {
                    for (int j = 1; j <= i; j++) 
                    {
                        Write(chr);
                    }
                    WriteLine();
                }

                for (int i = 1; i <= peak - 1; i++) 
                {
                    for (int j = peak-1; j >= i; j--) 
                    {
                        Write(chr);
                    }
                    WriteLine();                
                }



                WriteLine();
                Write("Do you need another triangle? <Y or N>");
                moreTriangle = ReadLine();
                Clear();
            }

            while (moreTriangle == "Y" || moreTriangle == "y");


        }
    }
}
