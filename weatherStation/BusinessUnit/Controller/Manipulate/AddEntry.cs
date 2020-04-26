//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        AddEntry.cs
//Datum:        18.04.2020
//Beschreibung: 
//Aenderungen:  18.04.2020 Erstellung
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weatherStation
{
    partial class main
    {
        static void AddEntry(ref Record[] weatherData, int entryPosition, ref Record newEntry)
        {
            if (entryPosition != -1)
            {
                MakeASpotForNewRecord(ref weatherData, entryPosition);
                weatherData[entryPosition].Humidity = newEntry.Humidity;
                weatherData[entryPosition].AirPressure = newEntry.AirPressure;
                weatherData[entryPosition].AirTemperature = newEntry.AirTemperature;
                weatherData[entryPosition].Date = newEntry.Date;
            }
            else
            {
                weatherData[FindLastRecordPlusOne(ref weatherData)] = newEntry;
            }
        }
    }
}
