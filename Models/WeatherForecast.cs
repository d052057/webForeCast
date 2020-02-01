using System;
using System.Collections.Generic;

namespace WebForecast.Models
{
    public partial class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int? TemperatureF { get; set; }
        public string Summary { get; set; }
    }
}
