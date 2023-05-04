using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A02StringOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "The quick brown fox jumps over lazy dog";

            int strringLength = sentence.Length;

            Console.WriteLine(strringLength);

            string s1 = sentence.Substring(4);

            Console.WriteLine(s1);
            string s2 = sentence.Substring(4,5);

            Console.WriteLine(s2);

            bool containsWord = sentence.Contains("jumps");

            Console.WriteLine(containsWord);

            bool b1 = true;
            bool b2 = false;

            string LowerCase = sentence.ToLower();
            string UpperCase = sentence.ToUpper();

            string ss3 = "the" + "quick" + "brown";

            string s4 = sentence + " again";

            string s5 = "quick".ToUpper();

            string s7 = sentence.Replace("jumps", "leaps");

            int position = sentence.IndexOf("quick");

            Console.ReadKey();

        }
    }
}
