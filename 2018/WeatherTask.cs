using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Xml;


namespace WetherApp
{
    class Program
    {
        static string temperature;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your city...");
            string city = Console.ReadLine();

            GetWeather(city);
            Console.ReadKey();
        }

        public static void GetWeather(string city)
        {
           string url = "https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20weather." +
                "forecast%20where%20woeid%20in%20(select%20woeid%20from%20geo.places(1)%20where%20text" +
                "%3D%22" + city +
                "%22)&format=xml&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys";
            
            WebClient Client = new WebClient();
            Client.Encoding = Encoding.UTF8;

            var downloadInfo = Client.DownloadString(url);
            if (downloadInfo == null)
            {
                throw new ArgumentNullException();
            }
            else Convert(downloadInfo);

            Console.WriteLine("The temperature in your city is " + temperature);
        }

        public static void Convert(string data)
        {
            string[] temp = data.Split('<');
            string result = temp[45].Split('=')[4].Split('"')[1];
            temperature = System.Convert.ToInt32(result).ToString();
        }
    }
}
