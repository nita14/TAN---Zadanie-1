using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebCrawlerAN
    {
        class Program
        {
            static async Task Main(string[] args)
            {
                string websiteUrl = "https://pja.edu.pl/";
                HttpClient httpclient = new HttpClient();
                HttpResponseMessage response = await httpclient.GetAsync(websiteUrl);

                string content = await response.Content.ReadAsStringAsync();

                //adresy e-mail i numery telefonu

                MatchCollection matchCollection = Regex.Matches(content, "[a-zA-Z0-9]+[@][a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})|[0-9][0-9] [0-9][0-9] [0-9][0-9] [0-9][0-9][0-9]");
                foreach (var res in matchCollection)
                {
                    Console.WriteLine(res);
                }


            }
        }
    }


