class WeatherData
{
    public double Temperature { get; set; }
    public double Humidity { get; set; }    
    public double WindSpeed { get; set; }    
    public string City { get; set; }="";
    public string WeatherDescription { get; set; }
    public DateTime Date { get; set; }
    public WeatherData(string City,double Temperature,double WindSpeed,double Humidity )
    {
        this.WindSpeed =WindSpeed;
        this.Temperature = Temperature;
        this.City= City;
        Date = DateTime.Now;
        this.Humidity = Humidity;
        WeatherDescription = $"The Date: {Date}\nThe City: {City}\nThe Temperatre: {Temperature}\nThe Humidity: {Humidity}\nThe Wind Speed: {WindSpeed}";
    }
}