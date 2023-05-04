using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace B01WebClient
{
    internal class Program
    {
        static void Main(string[] args)
        {

            WebClient myWebClient = new WebClient(); //we create new object and assing to variable

            string url = "https://www.google.com/search?q=weather+warsaw";
                string data = myWebClient.DownloadString(url);

            //Console.WriteLine(data);

            string resultPath = "c:\\data\\page.html";
            //string resultPath = @"c:\data\page.html";


            System.IO.File.WriteAllText(resultPath, data);



            Console.ReadKey();


        }
    }
}
