//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        BinarySearch.cs
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
            static int BinarySearch(ref Record[] weatherData, int searchParameter, string searchValue)
            {

                SelectionSort(ref weatherData, searchParameter);

                int arrLength = FindLastRecordPlusOne(ref weatherData);

                int pivot = 0;
                int lowerBorder = 0;
                int upperBorder = arrLength;

                switch (searchParameter)
                {
                    case 0:

                        while (lowerBorder <= upperBorder)
                        {
                            pivot = lowerBorder + ((upperBorder - lowerBorder) / 2);

                            if (searchValue == weatherData[pivot].Date)
                            {
                                return pivot;
                            }
                            else if (CompareDates(searchValue, weatherData[pivot].Date))
                            {
                                lowerBorder = pivot + 1;
                            }
                            else
                            {
                                upperBorder = pivot - 1;
                            }
                        }

                        break;


                    case 1:

                        while (lowerBorder <= upperBorder)
                        {
                            pivot = lowerBorder + ((upperBorder - lowerBorder) / 2);

                            if (Convert.ToDouble(searchValue) == weatherData[pivot].AirTemperature)
                            {
                                return pivot;
                            }
                            else if (Convert.ToDouble(searchValue) > weatherData[pivot].AirTemperature)
                            {
                                lowerBorder = pivot + 1;
                            }
                            else
                            {
                                upperBorder = pivot - 1;
                            }
                        }
                        break;
                    case 2:
                        while (lowerBorder <= upperBorder)
                        {
                            pivot = lowerBorder + ((upperBorder - lowerBorder) / 2);

                            if (Convert.ToInt32(searchValue) == weatherData[pivot].AirPressure)
                            {
                                return pivot;
                            }
                            else if (Convert.ToInt32(searchValue) > weatherData[pivot].AirPressure)
                            {
                                lowerBorder = pivot + 1;
                            }
                            else
                            {
                                upperBorder = pivot - 1;
                            }
                        }

                        break;

                    case 3:
                        while (lowerBorder <= upperBorder)
                        {
                            pivot = lowerBorder + ((upperBorder - lowerBorder) / 2);

                            if (Convert.ToInt32(searchValue) == weatherData[pivot].Humidity)
                            {
                                return pivot;
                            }
                            else if (Convert.ToInt32(searchValue) > weatherData[pivot].Humidity)
                            {
                                lowerBorder = pivot + 1;
                            }
                            else
                            {
                                upperBorder = pivot - 1;
                            }
                        }

                        break;
                }

                return -1;

            }
    }
}
