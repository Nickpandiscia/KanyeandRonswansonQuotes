using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanyeAndRonAPI
{
    public  class QuotesFromCelebs
    {
        public static void KanyeQuotes()
        {
            var client = new HttpClient(); //uses System.Net.Http; Helps you make a request to the internet.

            var kanyeURL = "https://api.kanye.rest"; //Where we will get our JSON info.

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result; //we send a GET request to the specified Uri and return the response body as a string in an asynchronous operation.  Basically, we get a string of JSON back

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"Kanye: {kanyeQuote}");
        }

        public static void RonSwansonQuotes()
        {
            var client = new HttpClient();

            var RonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(RonURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($" Ron: {ronQuote}");
        }

    }
}
