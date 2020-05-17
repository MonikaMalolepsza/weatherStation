//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        MakeASpotForNewRecord.cs
//Datum:        20.04.2020
//Beschreibung:
//Aenderungen:  20.04.2020 Erstellung

namespace weatherStation
{
    partial class main
    {

        static void MakeASpotForNewRecord (ref Record [] weatherData, int positionToBeFreed)
        {

            for (int i = FindLastRecordPlusOne(ref weatherData); i > positionToBeFreed; i--)
            {
                SwapRecords(ref weatherData, i, i-1);
            }
        }
    }
}