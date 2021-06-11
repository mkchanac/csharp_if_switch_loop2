using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch6_PE5
{
    class PurchaseAmountApp
    {
        static void Main()
        {
            string inValue;
            double totalAmountPurchase;
            int numOfItem;
            double salesTax;
            double shippingCharges;
            double grandTotal;

            Write("Enter the total purchase charge ($):");
            inValue = ReadLine();
            while (double.TryParse(inValue, out totalAmountPurchase) == false || totalAmountPurchase < 0) 
            {
                Write("Invalid entry, please make sure you enter the numerical value and it should be positive.");
                Write("\nRe-Enter the total purchase charge ($):");
                inValue = ReadLine();
            }

            Write("Enter the number of items purchased:");
            inValue = ReadLine();
            while (int.TryParse(inValue, out numOfItem) == false || numOfItem <= 0)
            {
                Write("Invalid entry, please make sure you enter an integer and it should be larger or equal to 1.");
                Write("\nRe-Enter the number of items purchased:");
                inValue = ReadLine();
            }

            salesTax = totalAmountPurchase * 7.75 / 100;

            if (numOfItem < 3)
                shippingCharges = 3.50;
            else
                if (numOfItem < 7)
                shippingCharges = 5.00;
            else
                if (numOfItem < 11)
                shippingCharges = 7.00;
            else
                if (numOfItem < 16)
                shippingCharges = 9.00;
            else 
                shippingCharges = 10.00;

            grandTotal = totalAmountPurchase + salesTax + shippingCharges;

            Clear();

            WriteLine("\tTotal amount due for purchases summary");
            WriteLine("*****************************************************");
            WriteLine("{0,-30}{1}", "Number of Items: ", numOfItem);
            WriteLine("{0,-30}{1:C2}", "Total Purchase Charge: ", totalAmountPurchase);
            WriteLine("{0,-30}{1:C2}", "Sales Tax Charge: ", salesTax);
            WriteLine("{0,-30}{1:C2}", "Shipping Charge: ", shippingCharges);
            WriteLine("-----------------------------------------------------");
            WriteLine("{0,-30}{1:C2}", "Grand Total: ", grandTotal);

            ReadKey();

        }
    }
}
