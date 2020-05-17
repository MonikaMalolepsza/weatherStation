//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        SwapRecords.cs
//Datum:        23.04.2020
//Beschreibung:
//Aenderungen:  23.04.2020 Erstellung

namespace weatherStation
{
    partial class main
    {

        static void SwapRecords (ref Record [] weatherData, int position1, int position2)
        {
            Record tempRecord = new Record
            {
                Date = weatherData[position1].Date,
                AirPressure = weatherData[position1].AirPressure,
                AirTemperature = weatherData[position1].AirTemperature,
                Humidity = weatherData[position1].Humidity,
            };

            weatherData[position1].Date = weatherData[position2].Date;
            weatherData[position1].AirPressure = weatherData[position2].AirPressure;
            weatherData[position1].AirTemperature = weatherData[position2].AirTemperature;
            weatherData[position1].Humidity = weatherData[position2].Humidity;

            weatherData[position2].Date = tempRecord.Date;
            weatherData[position2].AirPressure = tempRecord.AirPressure;
            weatherData[position2].AirTemperature = tempRecord.AirTemperature;
            weatherData[position2].Humidity = tempRecord.Humidity;

        }
    }
}