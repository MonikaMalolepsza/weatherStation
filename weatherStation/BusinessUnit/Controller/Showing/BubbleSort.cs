//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        BubbleSort.cs
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
        static void BubbleSort(ref Record[] weatherData, int sortParameter)
        {

                bool swapped = true;
                Defragment(ref weatherData);
                int upperBorder = FindLastRecordPlusOne(ref weatherData);

                if (sortParameter == 0)
                {
                    while (swapped)
                    {
                        swapped = false;
                        for (int index1 = 1; index1 < upperBorder; index1 = index1 + 1)
                        {
                            if (CompareDates(weatherData[index1].Date, weatherData[index1 - 1].Date))
                            {
                                SwapRecords(ref weatherData, index1 - 1, index1);
                                swapped = true;
                            }
                            else
                            {
                                //empty
                            }

                        }
                    }
                }
                else if (sortParameter == 1)
                {
                    while (swapped)
                    {
                        swapped = false;
                        for (int index1 = 1; index1 < upperBorder; index1 = index1 + 1)
                        {
                                if (weatherData[index1].AirTemperature < weatherData[index1 - 1].AirTemperature)
                                {
                                    SwapRecords(ref weatherData, index1 - 1, index1);
                                    swapped = true;
                                }
                                else
                                {
                                    //empty
                                }
                        }
                    }
                }
                else if (sortParameter == 2)
                {
                    while (swapped)
                    {
                        swapped = false;
                        for (int index1 = 1; index1 < upperBorder; index1 = index1 + 1)
                        {

                                if (weatherData[index1].AirPressure < weatherData[index1 - 1].AirPressure)
                                {
                                    SwapRecords(ref weatherData, index1 - 1, index1);
                                    swapped = true;
                                }
                                else
                                {
                                    //empty
                                }
                        }
                    }
                }
                else if (sortParameter == 3)
                {
                    while (swapped)
                    {
                        swapped = false;
                        for (int index1 = 1; index1 < upperBorder; index1 = index1 + 1)
                        {

                                if (weatherData[index1].Humidity < weatherData[index1 - 1].Humidity)
                                {
                                    SwapRecords(ref weatherData, index1 - 1, index1);
                                    swapped = true;
                                }
                                else
                                {
                                    //empty
                                }

                        }
                    }
                }
        }
    }
}

