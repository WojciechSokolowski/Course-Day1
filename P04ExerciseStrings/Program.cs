using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace P04ExerciseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("give number A");
            string A = Console.ReadLine();
            int AInt = Convert.ToInt32(A);
            Console.WriteLine("give number B");
            string B = Console.ReadLine();
            int BInt = Convert.ToInt32(B);


            int C = AInt + BInt;
            string sum = Convert.ToString(C);

            Console.WriteLine(sum);

            int lenC = sum.Length;
            string numberofchar = Convert.ToString(lenC);

            Console.WriteLine(lenC);


            //jak przerobiętypy to zadziała

            string report1 = "The resoult: " + sum + numberofchar + "digits";

            string report2 = $"the resoult:{sum} consists of: {numberofchar} digits";

            string report3 = string.Format("The resoult {0} consists of {1} digits", sum, numberofchar);

            Console.WriteLine(report1);
            Console.WriteLine(report2);
            Console.WriteLine(report3);


            Console.WriteLine(" Please give 2 numbers divided by space");
            string numbers = Console.ReadLine();

            int SpaceIndex = numbers.IndexOf(" ");

            int num1 = Convert.ToInt32(numbers.Substring(0,SpaceIndex));
            int num2 = Convert.ToInt32(numbers.Substring(SpaceIndex + 1));

            int num3 = num1 + num2;

            Console.WriteLine(num3);
            
            Console.ReadKey();

            


        }
    }
}
