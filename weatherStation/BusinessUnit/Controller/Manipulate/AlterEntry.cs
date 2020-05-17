//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        AlterEntry.cs
//Datum:        18.04.2020
//Beschreibung: 
//Aenderungen:  18.04.2020 Erstellung


namespace weatherStation
{
    partial class main
    {
        static void AlterEntry(ref Record[] weatherData, int entryPosition, ref Record alteredEntry)
        {
            weatherData[entryPosition] = alteredEntry;
        }
    }
}
