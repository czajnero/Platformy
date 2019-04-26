using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using ScrapySharp.Core;
using ScrapySharp.Html.Parsing;
using ScrapySharp.Extensions;
using System.IO;
using Newtonsoft.Json;

namespace JTTT
{
    [Serializable]
    class TempCheck : JTTTQuestion
    {
        public string City { get; set; }
        public double MinT { get; set; }

        private double actualT { get; set; }
        private MemoryStream imagestream; 

        private TempCheck() { }

        public TempCheck(string city, double minT)
        {
            City = city;
            MinT = minT;
        }

        public override void Question()
        {
            try
            {
                WebClient webClient = new WebClient();

                StringBuilder stringBuilder = new StringBuilder("http://api.openweathermap.org/data/2.5/weather?APPID=bfea97a6e19911df8ef1d2893df391dd&");
                stringBuilder.Append(City != null ? "q=" + City : "");
                var json = webClient.DownloadString(stringBuilder.ToString());

                stringBuilder.Clear();
                var weather = JsonConvert.DeserializeObject<WeatherObject>(json);

                actualT = weather.Temp;

                if (actualT >= MinT)
                {
                    stringBuilder.Append("http://api.openweathermap.org/img/w/");
                    stringBuilder.Append(weather.weather[0].icon);
                    stringBuilder.Append(".png");
                    imagestream = new MemoryStream(webClient.DownloadData(stringBuilder.ToString()));

                }
            }
            catch(Exception e)
            {

            }
            GetParameters();
        }

        private void GetParameters()
        {
            OutputParameters = new object[3];
            OutputParameters[0] = "Sprawdź pogodę! ";
            OutputParameters[1] = string.Format("Aktualna temperatura w {0} wynosi '{1}C", City,actualT.ToString("f1") );
            OutputParameters[2] = imagestream;
        }

        public override string ToString()
        {
            return string.Format("Miasto={0} Temperatura={1}", City, MinT);
        }
    }
}
