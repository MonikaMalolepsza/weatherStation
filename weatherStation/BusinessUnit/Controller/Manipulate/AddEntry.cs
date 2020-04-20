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
                weatherData[entryPosition].humidity = newEntry.humidity;
                weatherData[entryPosition].airPressure = newEntry.airPressure;
                weatherData[entryPosition].airTemperature = newEntry.airTemperature;
                weatherData[entryPosition].date = newEntry.date;
            }
            else
            {
                weatherData[FindLastRecordPlusOne(ref weatherData)] = newEntry;
            }
        }
    }
}
