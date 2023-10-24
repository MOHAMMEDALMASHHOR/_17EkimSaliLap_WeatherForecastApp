class WeatherForecast
{
    public WeatherData Weather { get; set; }
    public WeatherData SetWeather(string City,double Temperature,double WindSpeed,double Humidiiy)
    {
     return new WeatherData(City,Temperature,WindSpeed,Humidiiy);
    }
    public WeatherForecast(string City,double Temperature,double WindSpeed,double Humidiiy)
    {
        Weather = SetWeather(City,Temperature,WindSpeed,Humidiiy);
    
    }
    public void AutoDescription(){
        if (Weather.Temperature>=30.0 && Weather.WindSpeed<10.0)
        {
            System.Console.WriteLine("The Weather expected to be like: Hot and Calm");
        }
        else if (Weather.Temperature>=20.0&&Weather.WindSpeed>=10.0)
        {
            System.Console.WriteLine("The Weather expected to be like: Warm,mild,pleasent and Windy");
        }
        else if (Weather.Temperature>=10.0&&Weather.WindSpeed<10.0)
        {
            System.Console.WriteLine("The Weather expected to be like: Pleasant and Breeze(a light wind)");
        }
        else if(Weather.Temperature<10&&Weather.Temperature>0){
            System.Console.WriteLine("The Weather expected to be like: Chilly (unpleasantly cold)");
        }
        else{
            System.Console.WriteLine("The Weather expected to be like: below the zero, so it will be sonwy and freezing. take precautions and be assicuated with someone or the invoice of your treatment will be high!!!");
        }
    }
    public void GetWeatherForecast(){
        System.Console.WriteLine($"{Weather.WeatherDescription}\n");
        AutoDescription();
    }

}