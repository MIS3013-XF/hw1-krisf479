// HW1a Sales Total

// Your Name: Kristen Foster
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string itemtype;
            double numberofitems, itemprice;
            const double taxamt = 0.085;

            Console.WriteLine("What item would you like to purchase?");
            itemtype = Console.ReadLine();
            Console.WriteLine($"How many {itemtype} would you like to buy?");
            numberofitems = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"What is the price of {itemtype}?");
            itemprice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"\n\tThe subtotal of your purchase is ${numberofitems * itemprice}.");
            Console.WriteLine($"\tThe sales tax for your purchase is ${(numberofitems * itemprice) * taxamt}.");
            Console.WriteLine($"\tThe total of your purchase is ${(itemprice*numberofitems) + taxamt*(itemprice*numberofitems)}.");
          

        }
    }
}
