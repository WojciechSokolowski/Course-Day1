using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace P13Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("################################");
            Console.WriteLine("############ TASK 1 ############");
            Console.WriteLine("################################");

            // TASK 1

            int n = 50;
            int sum = 0;

            for(int i = 1; i <= n;i++)
            {
                if (i % 2 == 0)
                    sum += i;
            }
            Console.WriteLine($"Sum of all even numbers from 1 to {n} is {sum}");



            Console.WriteLine("################################");
            Console.WriteLine("############ TASK 2 ############");
            Console.WriteLine("################################");

            Console.WriteLine("Please provide 2 numbers, one after another");

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 =Convert.ToInt32(Console.ReadLine());

            string report = "the greater number is {0}";

            if (num1 > num2)
                Console.WriteLine(num1);
            else
                Console.WriteLine(num2);

            Console.WriteLine("################################");
            Console.WriteLine("############ TASK 3 ############");
            Console.WriteLine("################################");

            List<int> Numbers = new List<int>();
            Numbers.Add(3);
            Numbers.Add(5);
            Numbers.Add(7);
            Numbers.Add(5);
            Numbers.Add(1);
            Numbers.Add(6);
            Numbers.Add(12);
            Numbers.Add(245);
            Numbers.Add(2);
            Numbers.Add(46);

            double SumList = 0.0;
            for (int i = 0; i < Numbers.Count; i++)
                SumList += Numbers[i];
            SumList /= Numbers.Count;

            Console.WriteLine($"Average of this list is {SumList}");


            Console.WriteLine("################################");
            Console.WriteLine("############ TASK 4 ############");
            Console.WriteLine("################################");



            for (int i= 2;  i<=100 ; i++)
            {
                bool IsPrime = true;
                for (int j = 2; j< i; j++)
                {
                    if (i%j==0)
                        IsPrime = false;
                }
                if (IsPrime)
                    Console.WriteLine(i);
            }


            Console.WriteLine("################################");
            Console.WriteLine("############ TASK 5 ############");
            Console.WriteLine("################################");


            WebClient wc = new WebClient();
            
            string url = "https://naukawpolsce.pl/sites/default/files/styles/strona_glowna_slider_750x420/public/202005/portretProboscis_monkey_%28Nasalis_larvatus%29_male_head_0.jpg?itok=xjDuaGnc";

            wc.DownloadFile(url, @"c:\data\nosacz.png");

            Console.WriteLine("################################");
            Console.WriteLine("############ TASK 6 ############");
            Console.WriteLine("################################");


            Console.WriteLine("Please write a number which is upper limit of sequence");
            int Max = Convert.ToInt32(Console.ReadLine());
            int OldIndex = 0;
            int Index = 1;
            int NewIndex = 0;
            while (Index <= Max)
            {
                Console.WriteLine(Index);

                NewIndex = Index + OldIndex;
                OldIndex = Index;
                Index = NewIndex;


            }

            Console.ReadKey();
        }
    }
}
