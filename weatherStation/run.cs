//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        run.cs
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
        struct Record
        {
             public string date;
             public double airTemperature;
             public uint airPressure;
             public uint humidity;
        }

        static void run()
        {
            Record[] weatherData = new Record[366];

        }

    }
}
