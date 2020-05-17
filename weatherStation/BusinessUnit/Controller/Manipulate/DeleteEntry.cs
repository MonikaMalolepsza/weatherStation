//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        DeleteEntry.cs
//Datum:        18.04.2020
//Beschreibung: 
//Aenderungen:  18.04.2020 Erstellung


namespace weatherStation
{
    partial class main
    {
        static void DeleteEntry(ref Record[] weatherData, int entryPosition)
        {

            weatherData[entryPosition].Date = "";
            weatherData[entryPosition].AirTemperature = 0.00;
            weatherData[entryPosition].AirPressure = 0;
            weatherData[entryPosition].Humidity = 0;

        }
    }
}
