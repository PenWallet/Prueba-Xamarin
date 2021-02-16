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
        private static string city = "Sevilla";
        private static string units = "metric"; //Can be standard, metric or imperial

        public static WeatherToday GetTodayWeather()
        {
            var uri = new Uri($"{url}/weather?q={city}&units={units}&appid={access_key}");
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
                    }
                    catch (Exception ex)
                    {
                        Console.Out.WriteLine(ex.Message);
                    }
                }
            }

            return new WeatherToday();
        }

        public static WeatherForecast GetForecastWeather()
        {
            var uri = new Uri($"{url}/forecast?q={city}&units={units}&appid={access_key}");
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
                        WeatherForecast weatherForecast = JsonConvert.DeserializeObject<WeatherForecast>(content);

                        return weatherForecast;
                    }
                    catch (Exception ex)
                    {
                        Console.Out.WriteLine(ex.Message);
                    }
                }
            }

            return new WeatherForecast();
        }
    }
}
