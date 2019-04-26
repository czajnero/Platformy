using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JTTT
{
    public partial class FormWeatherChecker : Form
    {
        public FormWeatherChecker()
        {
            InitializeComponent();
        }

        private void WeatherForm_Load(object sender, EventArgs e)
        {

        }
        private void CityButton_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();

            StringBuilder stringBuilder = new StringBuilder("http://api.openweathermap.org/data/2.5/weather?APPID=bfea97a6e19911df8ef1d2893df391dd&");
            stringBuilder.Append("q=" + CityTextBox.Text);
            var json = webClient.DownloadString(stringBuilder.ToString());

            stringBuilder.Clear();
            var weather = JsonConvert.DeserializeObject<WeatherObject>(json);

            stringBuilder.AppendLine(string.Format("Temperatura: {0} C", weather.Temp.ToString("f1")));
            stringBuilder.AppendLine(string.Format("Cisnienie powietrza: {0} hPa", weather.main.pressure));
            stringBuilder.AppendLine(string.Format("Wiatr: {0} m/s", weather.wind.speed));
            stringBuilder.AppendLine(string.Format("Zachmurzenie: {0}", weather.weather[0].description));

            WeatherDescriptionTextBox.Text = stringBuilder.ToString();

            stringBuilder.Clear();

            stringBuilder.Append("http://api.openweathermap.org/img/w/");

            stringBuilder.Append(weather.weather[0].icon);

            stringBuilder.Append(".png");

            MemoryStream stream = new MemoryStream(webClient.DownloadData(stringBuilder.ToString()));
            PictureBox.Image = Image.FromStream(stream);
        }

        private void WeatherDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    public class Sys
    {
        public double message { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }
    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }
    public class Main
    {
        public double temp { get; set; }
        public int humidity { get; set; }
        public int pressure { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
    }

    public class Wind
    {
        public double speed { get; set; }
        public double gust { get; set; }
        public int deg { get; set; }
    }

    public class Rain
    {
        public int __invalid_name__3h { get; set; }
    }

    public class Clouds
    {
        public int all { get; set; }
    }

    public class WeatherObject
    {
        public Coord coord { get; set; }
        public Sys sys { get; set; }
        public List<Weather> weather { get; set; }
        public string @base { get; set; }
        public Main main { get; set; }
        public Wind wind { get; set; }
        public Rain rain { get; set; }
        public Clouds clouds { get; set; }
        public int dt { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }

        public double Temp
        {
            get { return (main.temp - 273.0); }
        }
    }
    
}
