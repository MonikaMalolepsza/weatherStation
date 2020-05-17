//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        AddEntry.cs
//Datum:        18.04.2020
//Beschreibung: 
//Aenderungen:  17.05.2020 Erstellung


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
