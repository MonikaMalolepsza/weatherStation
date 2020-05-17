//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        RandomDataGenerator.cs
//Datum:        23.04.2020
//Beschreibung:
//Aenderungen:  23.04.2020 Erstellung

using System;

namespace weatherStation
{
    partial class main
    {
        static Random r = new Random();
        static void RandomDataGenerator(ref Record[] weatherData, int numberOfEntries)
        {
            for (int i = 0; i < weatherData.Length; i++)
            {
                if (i < numberOfEntries)
                {
                    weatherData[i] = CreateValidRandomEntry();
                }
                else
                {
                    weatherData[i] = new Record { Date = "", AirTemperature = 0.0d, AirPressure = 0, Humidity = 0 };
                }
            }

        }

        static Record CreateValidRandomEntry()
        {
            //Date
            DateTime start = new DateTime(1900, 1, 1);
            string nDate = "27.12.1990";
            // string nDate = start.AddDays(r.Next((DateTime.Today - start).Days)).Date.ToString().Substring(0, 10);
            //Temperature
            double nTemperature = r.NextDouble() * (60.0 - (-50.0)) + (-50.0);
            //Pressure
            uint nPressure = (uint)r.Next(700, 1080);
            //Humidity
            uint nHumidity = (uint)r.Next(0, 100);
            return new Record { Date = nDate, AirTemperature = nTemperature, AirPressure = nPressure, Humidity = nHumidity };
        }
    }
}