using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace A08ExerciseConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("plese enter equation");

            string s1 = Console.ReadLine();

      

            int num1 = Convert.ToInt32(s1.Substring(0,1));
            string sign = s1.Substring(1,1);
            int num2 = Convert.ToInt32(s1.Substring(2,1));

            double? num3=null;

            if (sign == "+")
                num3 = num1 + num2;
            else if (sign == "-")
                num3 = num1 - num2;
            else if(sign == "*")
              num3 = num1 * num2;
            else if (sign == "/") 
                num3 = Convert.ToDouble(num1) / num2;

            if (num3 != null)
                Console.WriteLine(num3);
            else
                Console.WriteLine("error, cant calculate");

            Console.ReadKey();  
        }
    }
}
