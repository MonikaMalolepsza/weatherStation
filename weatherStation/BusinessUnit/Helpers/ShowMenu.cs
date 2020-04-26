//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        ShowMenu.cs
//Datum:        18.04.2020
//Beschreibung: Erhält ein String-Array mit den anzuzeigenden Menüpunkten und eine Headline
//              Nach Auswahl durch Enter-Taste wird als Integer die Position des Ausgewählten
//              Wertes zurückgegeben.
//Aenderungen:  18.04.2020 Erstellung

using System;

namespace weatherStation
{

    partial class main
    {
        static int ShowMenu(ref string[] MenuPoints, string Headline)
        {
            int currentItem = 0;
            ConsoleKeyInfo key = new ConsoleKeyInfo();

            do
            {
                Console.Clear();
                Console.WriteLine(Headline + "\n");

                for (int counter = 0; counter < MenuPoints.Length; counter++)
                {
                    if (currentItem == counter)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(MenuPoints[counter]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.WriteLine(MenuPoints[counter]);
                    }
                }

                Console.WriteLine("\n\nYou can navigate with the arrow keys.\nConfirm your entry with the return key.");
                key = Console.ReadKey(true);
                if (key.Key.ToString() == "DownArrow")
                {
                    currentItem++;
                    if (currentItem > MenuPoints.Length - 1) currentItem = 0;
                }
                else if (key.Key.ToString() == "UpArrow")
                {
                    currentItem--;
                    if (currentItem < 0) currentItem = MenuPoints.Length - 1;
                }
            } while (key.Key.ToString() != "Enter");

            return currentItem;
        }
    }
}