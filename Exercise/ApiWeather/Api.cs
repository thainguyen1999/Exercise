using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Exercise.ApiWeather
{
    public class Api
    {
       static void Main(string[] args)
        {
            string city = "Ha Noi";
            string country = "Viet Nam";
            string appId = "09a71427c59d38d6a34f89b47d75975c";
            string unit = "metric";
            string url = "https://api.openweathermap.org/data/2.5/weather?q={city},{country}&appid={appId}&units={units}";

            using (WebClient webClient = new WebClient())
            {
                string json = webClient.DownloadString(url);
               WeatherData weatherData= JsonConvert.DeserializeObject<WeatherData>(json);

                Console.WriteLine($"Thành phố: {weatherData.Name}");
                Console.WriteLine($"Nhiệt độ: {weatherData.M.Temp} độ C");
                Console.WriteLine($"Độ ẩm: {weatherData.M.Humidity}%");
                Console.WriteLine($"Tình trạng: {weatherData.Weather[0].Description}");
            }
        }
    }
    public class M
    {
        public float Temp { get; set; }
        public int Humidity { get; set; }
    }

    public class Weather
    {
        public string Description { get; set; }
    }
}
