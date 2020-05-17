//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Median.cs
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
        static double Median(ref Record[] weatherData, int calculationParameter)
        {
            BubbleSort(ref weatherData, calculationParameter + 1);
            int upperBorder = FindLastRecordPlusOne(ref weatherData);
            switch (calculationParameter)
            {
                case 0: return weatherData[upperBorder / 2].AirTemperature;
                case 1: return weatherData[upperBorder / 2].AirPressure;
                case 2: return weatherData[upperBorder / 2].Humidity;
                default: return -1;
            }
        }
    }
}

