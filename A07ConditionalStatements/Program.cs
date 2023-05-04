using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A07ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your height");

            int height = Convert.ToInt32(Console.ReadLine());

            bool condition1 = height > 180;

            if (condition1)
            {
                Console.WriteLine("tall");
            }
            else
            {
                Console.WriteLine("short");
            }

            if (height < 160)
                Console.WriteLine("short");
            else if(height >180)
                Console.WriteLine("tall");
            else
                Console.WriteLine("average");

            string report;

            if (height < 150)
                report = "very short";
            else if (height < 160)
                report = "short";
            else if (height < 170)
                report = "average";
            else if (height < 180)
                report = "tall";
            else 
                report = "very tall";

            report = $"your height is {height} and you are {report}";
            Console.WriteLine(report);

            // ternary operator
            string resoult;
            if (height > 180)
                resoult = "tall";
            else
                resoult = "short";

            string resoult1 = height > 180 ? "tall" : "short";

            string resoult2 = height > 180 ? "very tall" : height < 160 ? "short" : "average";





        }
    }
}
