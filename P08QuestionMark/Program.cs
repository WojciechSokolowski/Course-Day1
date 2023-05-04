using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08QuestionMark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int a = null; //syntax error
            int? b = null; //now b can store null value

            string c = null;    // its not a problem because string is by default nullable type
            //string? d= null; //syntaxerror

            //bool d = false; //syntax error
            bool? e = false;

        }

    }
}
