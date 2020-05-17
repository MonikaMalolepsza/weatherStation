//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        ArithmeticMean.cs
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
        static double ArithmeticMean(ref Record[] weatherData, int calculationParameter)
        {
            double mean = 0;
            int numberElements;
            int upperBorder = FindLastRecordPlusOne(ref weatherData);
            switch (calculationParameter)
            {
                case 0:
                    for (numberElements = 0; numberElements < upperBorder; numberElements++)
                    {
                        mean += weatherData[numberElements].AirTemperature;
                    }
                    break;
                case 1:
                    for (numberElements = 0; numberElements < upperBorder; numberElements++)
                    {
                        mean += weatherData[numberElements].AirPressure;
                    }
                    break;
                case 2:
                    for (numberElements = 0; numberElements < upperBorder; numberElements++)
                    {
                        mean += weatherData[numberElements].Humidity;
                    }
                    break;
                default: return -1;
            }

            return mean / numberElements;
        }
    }
}
