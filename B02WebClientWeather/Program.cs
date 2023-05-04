using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace B02WebClientWeather
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                WebClient myWebClient = new WebClient();
                Console.WriteLine("Give name of the city");
                string city = Console.ReadLine();

                string url = $"https://www.google.com/search?q=weather+{city}";
                string data = myWebClient.DownloadString(url);

                string SearchChar = "°";
                string EndChar = ">";
                try { 
                int DegreeIndex = data.IndexOf("°");
                int Index = DegreeIndex;
                while (data.Substring(Index, 1) != ">")
                {
                    Index--;
                }
                string temperature = data.Substring(Index + 1, DegreeIndex - Index + 1);
                Console.WriteLine("Temperature in " + city + " is " + temperature);
            }
            catch(Exception){
                Console.WriteLine("failed to retrieve temp");
                continue;
            }


            }
                Console.ReadKey();

            
            
        }
    }
}
