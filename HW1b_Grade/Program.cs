// HW1b Grade

// Your Name: Kristen Foster
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double hwgrade,participationgrade, quizgrade, midtermgrade, finalgrade;
            string firstname, lastname, studentid;
            const double pw = 0.15, hww = 0.2, fgw = 0.25, qw = 0.15, mtw = 0.25;

            Console.WriteLine("What is your first name?");
            firstname = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            lastname = Console.ReadLine();
            Console.WriteLine("What is your student id number?");
            studentid = Console.ReadLine();
            Console.WriteLine("What is your overall percentage HW grade?");
            hwgrade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage participation grade?");
            participationgrade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage quiz grade?");
            quizgrade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage midterm grade?");
            midtermgrade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your percentage final grade?");
            finalgrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{firstname} {lastname} ({studentid}), your final grade is {hwgrade*hww+ participationgrade*pw + quizgrade*qw + midtermgrade*mtw + finalgrade*fgw}%");



        
        }
    }
}
