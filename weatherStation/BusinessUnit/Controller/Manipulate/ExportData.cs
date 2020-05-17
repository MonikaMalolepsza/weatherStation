//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        ExportData.cs
//Datum:        18.04.2020
//Beschreibung:
//Aenderungen:  18.04.2020 Erstellung

using System.IO;
using System.Text;

namespace weatherStation
{
    partial class main
    {
        static void ExportData(ref Record[] weatherData, string destinationPath)
        {
            FileStream FS = new FileStream(destinationPath + ".csv", FileMode.Create, FileAccess.Write);
            StreamWriter SW = new StreamWriter(FS, Encoding.UTF8);

            int upperBorder = FindLastRecordPlusOne(ref weatherData);

            SW.WriteLine("Date;Air Temperature;Air Pressure;Humidity");
            for (int i = 0; i < upperBorder; i++)
            {
                SW.WriteLine($"{weatherData[i].Date};{weatherData[i].AirTemperature};{weatherData[i].AirPressure};{weatherData[i].Humidity}");
            }
            SW.Close();
            FS.Close();
        }
    }
}