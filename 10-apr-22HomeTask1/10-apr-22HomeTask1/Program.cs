using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _10_apr_22HomeTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient cilent = new HttpClient();
            string response = cilent.GetStringAsync("https://www.cbar.az/currencies/10.04.2022.xml").Result;
            // Console.WriteLine(response);
            //Console.ReadLine();

            string resJson = JsonConvert.SerializeObject(response);

            StreamWriter sw = new StreamWriter(@"C:\Users\comp\source\repos\10-apr-22HomeTask1\10-apr-22HomeTask1\File\main.json");
            sw.Write(resJson);
            sw.Close();
        }
    }
}
