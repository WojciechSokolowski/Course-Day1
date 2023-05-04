using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A06Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;

            bool isEqual = a == 1;

            a = a + 1;
            a++;
            a += 5;

            a *= 2;

            a -= 5;

            a /= 2;

            bool isLess = a < 5;

            bool isGreaterorEqual = a >= 5;

            bool orCondition = a < 5 || a > 10;

            bool andCondition = a > 5 && a < 10;

            bool isdiffrent = !(a == 5);




        }
    }
}
