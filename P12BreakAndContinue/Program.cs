using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12BreakAndContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//TODO continue
            int index = 0;
            int SpacePosition = -1;
            while (index < equation.Length)
            {
                if (equation.Substring(index, 1) == " ")
                {
                    SpacePosition = index;
                    break; //exits from while 
                }
            }
            */


            // break
            //string equation = "10 200";
            ////012345                
            ////  i
            //int index = 0;
            //int spacePosition = -1;
            //while (index < equation.Length)
            //{
            //    if (equation.Substring(index, 1) == " ")
            //    {
            //        spacePosition = index;
            //        break; // exits from while 
            //    }
            //    index++;
            //}

            string equation = "10 200";
            //012345                
            //  i
            int index = 0;
            int spacePosition = -1;
            while (index < equation.Length)
            {
                if (equation.Substring(index, 1) == " ")
                {
                    spacePosition = index;

                    if (index == 2)
                        continue; // skips actual iteration 
                }
                index++;
            }


        }
    }
}