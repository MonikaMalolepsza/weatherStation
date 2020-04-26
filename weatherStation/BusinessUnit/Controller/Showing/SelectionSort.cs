//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        QuickSort.cs
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
        static void SelectionSort(ref Record[] weatherData, int sortParameter)
        {
            int pivot = -1;
            Defragment(ref weatherData);
            int upperBorder = FindLastRecordPlusOne(ref weatherData);

            if (sortParameter == 0)
            {
                for (int outerLoop = 0; outerLoop < upperBorder; outerLoop = outerLoop + 1)
                {
                    pivot = outerLoop;
                    for (int innerLoop = outerLoop; innerLoop < upperBorder; innerLoop = innerLoop + 1)
                    {

                            if (CompareDates(weatherData[innerLoop].Date, weatherData[pivot].Date))
                            {
                                pivot = innerLoop;
                            }
                            else
                            {
                                //empty
                            }

                    }
                    SwapRecords(ref weatherData, outerLoop, pivot);
                }
            }
            else if (sortParameter == 1)
            {
                for (int outerLoop = 0; outerLoop < upperBorder; outerLoop = outerLoop + 1)
                {
                    pivot = outerLoop;
                    for (int innerLoop = outerLoop; innerLoop < upperBorder; innerLoop = innerLoop + 1)
                    {

                            if (weatherData[innerLoop].AirTemperature < weatherData[pivot].AirTemperature)
                            {
                                pivot = innerLoop;
                            }

                            else
                            {
                                // empty
                            }
                    }
                    SwapRecords(ref weatherData, outerLoop, pivot);
                }
            }
            else if (sortParameter == 2)
            {
                for (int outerLoop = 0; outerLoop < upperBorder; outerLoop = outerLoop + 1)
                {
                    pivot = outerLoop;
                    for (int innerLoop = outerLoop; innerLoop < upperBorder; innerLoop = innerLoop + 1)
                    {

                            if (weatherData[innerLoop].AirPressure < weatherData[pivot].AirPressure)
                            {
                                pivot = innerLoop;
                            }
                            else
                            {
                                //empty
                            }

                    }
                    SwapRecords(ref weatherData, outerLoop, pivot);
                }
            }
            else if (sortParameter == 3)
            {
                for (int outerLoop = 0; outerLoop < upperBorder; outerLoop = outerLoop + 1)
                {
                    pivot = outerLoop;
                    for (int innerLoop = outerLoop; innerLoop < upperBorder; innerLoop = innerLoop + 1)
                    {

                            if (weatherData[innerLoop].Humidity < weatherData[pivot].Humidity)
                            {
                                pivot = innerLoop;
                            }
                            else
                            {
                                //empty
                            }

                    }
                    SwapRecords(ref weatherData, outerLoop, pivot);
                }
            }
            else
            {
                //Nichts
            }
        }
    }
}
