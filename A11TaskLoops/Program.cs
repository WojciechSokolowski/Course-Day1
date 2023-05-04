using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11TaskLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write sentence");
            string sentence = Console.ReadLine();
            Console.WriteLine("Write character or word");
            string word = Console.ReadLine();

            int WordLength = word.Length;
            int SentenceLength = sentence.Length;

            int i = 0;
            int counter = 0;

            while (i < SentenceLength-WordLength+1)
            {
                string SubSentence = sentence.Substring(i, WordLength);
                
                if (SubSentence == word)
                {
                    counter++;
                }


                    i++;
            }

            Console.WriteLine("your word/character "+ word  +" was used "+Convert.ToString(counter) + " times");

            Console.ReadKey();

        }
    }
}
