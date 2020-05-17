//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Import.cs
//Datum:        18.04.2020
//Beschreibung: 
//Aenderungen:  18.04.2020 Erstellung
using System;
using System.IO;
using System.Text;

namespace weatherStation
{
    partial class main
    {
        static string ImportData(ref Record[] weatherData, string filePath)
        {
            DeleteAllData(ref weatherData);
            FileStream FS = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(FS, Encoding.UTF8);
            string[] currentLine = SR.ReadLine().Split(';');
            Record insertRecord;
            string errorLog = "The following records could not be imported:\r\n";
            bool validated;
            int errorCounter = 0;

            for (int index = 1; !SR.EndOfStream; index++)
            {
                currentLine = SR.ReadLine().Split(';');
                insertRecord = new Record { Date = currentLine[0], AirTemperature = Convert.ToDouble(currentLine[1]), AirPressure = Convert.ToUInt32(currentLine[2]), Humidity = Convert.ToUInt32(currentLine[3]) };
                validated = ValidateEntry(ref weatherData, ref insertRecord);
                if (validated)
                {
                    AddEntry(ref weatherData, index, ref insertRecord);
                }
                else
                {
                    errorCounter++;
                    errorLog += "Invalid entry " + index + ": " + currentLine + "\r\n";
                }
            }
            SR.Close();
            FS.Close();
            return errorCounter==0?"":errorLog;
        }
    }
}