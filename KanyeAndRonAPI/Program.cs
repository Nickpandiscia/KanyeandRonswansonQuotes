using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace KanyeAndRonAPI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to the famous person quote generator.");
            Console.WriteLine("Today, we have Ron Swanson and Kanye West quotes.");
            Console.WriteLine("Which persons quotes do you wanna look at?");

            var userResponse = Console.ReadLine();

            if(userResponse == "kanye".ToLower())
            {
                QuotesFromCelebs.KanyeQuotes();
            }

            if(userResponse == "ron swanson".ToLower())
            {
                QuotesFromCelebs.RonSwansonQuotes();
            }
        }
    }
}
