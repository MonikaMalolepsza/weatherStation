//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        DeleteAllData.cs
//Datum:        16.05.2020
//Beschreibung:
//Aenderungen:  16.05.2020 Erstellung

namespace weatherStation
{

        partial class main
        {
            static void DeleteAllData(ref Record[] weatherData)
            {
                int upperBorder = FindLastRecordPlusOne(ref weatherData);
                for (int counter = 0; counter < upperBorder; counter++)
                {
                    weatherData[counter].Date = "";
                    weatherData[counter].AirTemperature = 0.0;
                    weatherData[counter].AirPressure = 0;
                    weatherData[counter].Humidity = 0;
                }
            }
        }

}