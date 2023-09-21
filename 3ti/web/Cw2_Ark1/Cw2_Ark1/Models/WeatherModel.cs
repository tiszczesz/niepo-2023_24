namespace Cw2_Ark1.Models
{
    public class WeatherModel
    {
        public int Id { get; set; }
        public int IdCity { get; set; }
        public int TempNight { get; set; }
        public int TempDay { get; set; }
        public DateTime DateWeather { get; set; }
        public int RainFall { get; set; }
        public int Pressure { get; set;}
    }
}
