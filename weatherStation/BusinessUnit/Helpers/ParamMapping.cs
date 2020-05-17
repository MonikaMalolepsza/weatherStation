//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        ParamMapping.cs
//Datum:        23.04.2020
//Beschreibung:
//Aenderungen:  23.04.2020 Erstellung

namespace weatherStation
{
    partial class main
    {
        static string ParamMapping(int parameter)
        {
            switch (parameter)
            {
                case 0:
                    return "Date";
                case 1:
                    return "airTemperature";
                case 2:
                    return "airPressure";
                case 3:
                    return "humidity";
                default:
                    return "Error";
            }
        }
    }
}