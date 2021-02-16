using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Xamarin_Weather.Models;

namespace Xamarin_Weather.Services
{
    public static class WeatherAPICalls
    {
        private static string url = "http://api.openweathermap.org/data/2.5";
        private static string access_key = "990f538e007ac3b9b460473b05ff4082";

        public static WeatherToday GetTodayAndForecastWeather()
        {
            var uri = new Uri($"{url}/weather?q=Sevilla&units=metric&appid={access_key}");
            var request = HttpWebRequest.Create(uri);
            request.ContentType = "application/json";
            request.Method = "GET";

            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    Console.Out.WriteLine("Whoops: {1}", response.StatusCode);

                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    try
                    {
                        var content = reader.ReadToEnd();
                        WeatherToday weatherToday = JsonConvert.DeserializeObject<WeatherToday>(content);

                        if (weatherToday.rain == null)
                            weatherToday.rain = new WeatherToday.Rain();
                        return weatherToday;
                    }catch(Exception ex) 
                    { 
                        Console.Out.WriteLine(ex.Message);
                    }
                }
            }

            return new WeatherToday();
        }
    }
}
