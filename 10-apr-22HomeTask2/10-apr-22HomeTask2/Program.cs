using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _10_apr_22HomeTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            string response = client.GetStringAsync("https://jsonplaceholder.typicode.com/posts").Result;

            Console.WriteLine(response);
            Console.ReadLine();




        }
    }
}
