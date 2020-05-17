//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        FindLastRecordPlusOne.cs
//Datum:        20.04.2020
//Beschreibung:
//Aenderungen:  20.04.2020 Erstellung

namespace weatherStation
{
    partial class main
    {

        static int FindLastRecordPlusOne (ref Record [] weatherData)
        {
            Defragment(ref weatherData);

            for (int i = 0; i < weatherData.Length; i++)
            {
                if (weatherData[i].Date == "")
                {
                    return i;
                }
            }

            return 366;
        }
    }
}