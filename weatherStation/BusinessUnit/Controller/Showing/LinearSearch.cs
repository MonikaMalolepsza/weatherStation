//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        LinearSearch.cs
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
       
            static int LinearSearch(ref Record[] weatherData, int searchParameter, string searchValue)
            {
                int i = 0;
                int upperBoarder = FindLastRecordPlusOne(ref weatherData);
                if (searchParameter == 0)
                {
                    for (i = 0; i < upperBoarder; i++)
                    {
                        if (weatherData[i].Date == searchValue)
                        {
                            return i;
                        }
                        else
                        {
                            //empty
                        }
                    }
                }
                else if (searchParameter == 1)
                {
                    for (i = 0; i < upperBoarder; i++)
                    {
                        if (weatherData[i].AirTemperature == Convert.ToDouble(searchValue))
                        {
                            return i;
                        }
                        else
                        {
                            //empty
                        }
                    }
                }
                else if (searchParameter == 2)
                {
                    for (i = 0; i < upperBoarder; i++)
                    {
                        if (weatherData[i].AirPressure == Convert.ToInt32(searchValue))
                        {
                            return i;
                        }
                        else
                        {
                            //empty
                        }
                    }
                }
                else if (searchParameter == 3)
                {
                    for (i = 0; i < upperBoarder; i++)
                    {
                        if (weatherData[i].Humidity == Convert.ToInt32(searchValue))
                        {
                            return i;
                        }
                        else
                        {
                            //empty
                        }
                    }
                }
                else
                {
                    return -1;
                }

                return -1;
            }
        }
}
